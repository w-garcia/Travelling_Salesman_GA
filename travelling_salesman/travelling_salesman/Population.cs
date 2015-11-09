using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace travelling_salesman
{
    class Population
    {
        private Problem _problem;
        List<Solution> solutionList = new List<Solution>();

        private Solution _bestSolution = new Solution();
        private Solution _initialSolution = new Solution();
        private double _workDone = 0;
        private static int _generationsSoFar = 0;

        #region public properties 

        public double WorkDone
        {
            get { return _workDone; }
            set { _workDone = value; }
        }

        public Solution BestSolution
        {
            get { return _bestSolution; }
            set { _bestSolution = value; }
        }

        public int GenerationsSoFar
        {
            get { return _generationsSoFar; }
            set { _generationsSoFar = value; }
        }

        public Solution InitialSolution
        {
            get { return _initialSolution; }
            set { _initialSolution = value; }
        }



        #endregion
       
        public Population(Problem problem)
        {
            _problem = problem;
            InitializePopulation();
            _bestSolution = new Solution();
            _generationsSoFar = 0;
        }

        private void InitializePopulation()
        {
            solutionList.Clear();
            for (int i = 0; i < EvolutionHelper.populationSize; i++)
            {
                solutionList.Add(new Solution());
            }
            EvaluatePopulation();
        }

        private void EvaluatePopulation()
        {
            foreach (Solution s in solutionList)
            {
               _problem.EvaluateSolution(s);
            }
        }
        
        public void RunGenerations(int generations, BackgroundWorker worker)
        {

            CheckBestSolution(ref _initialSolution);

            for (int i = 0; i < generations; i++)
            {
                RunGeneration();

                int percentage = (int)(100.0 * (((double)i) / ((double)generations)));

                worker.ReportProgress(percentage);
            }


        }

        private void RunGeneration()
        {
            Tournaments();
            Mutate();
            _generationsSoFar++;
            CheckBestSolution(ref _bestSolution);
        }

        private void CheckBestSolution(ref Solution solutionToSave)
        {
            foreach(Solution s in solutionList)
            {
                if (s < solutionToSave)
                {
                    solutionToSave = new Solution(s);
                }
            }
        }

        private void Tournaments()
        {
            Shuffle(); // shuffle solution list
            for (int i = 0; i < solutionList.Count() - 4; i += 4)
            {
                RunOneTournament(i);
            }
        }

        private void RunOneTournament(int start)
        {
           // solutionList.Sort();
            solutionList.Sort(start, 4, null); // Sort solutions by fitness 
            Mate(start);
        }

        private void Mate(int start)
        {
            int cross1 = EvolutionHelper.rand(100);
            int cross2 = cross1;
            while (cross1 == cross2)
            {
                cross1 = EvolutionHelper.rand(100);
            }
            if (cross1 > cross2) SwapInt(ref cross1, ref cross2);

            Solution parent1 = solutionList[start];
            Solution parent2 = solutionList[start + 1];

            List<double> child1Tour = new List<double>();
            List<double> child2Tour = new List<double>();

            for (int i = 0; i < 100; i++)
            {
                //double randUpperLimit = EvolutionHelper.randDouble(1);
                if ((i < cross1) || (i > cross2)) // two point crossover
                //if (EvolutionHelper.randDouble(1) < .6) // uniform crossover
                {
                    child1Tour.Add(parent1.Genome[i]);
                    child2Tour.Add(parent2.Genome[i]);
                }
                else
                {
                    child1Tour.Add(parent2.Genome[i]);
                    child2Tour.Add(parent1.Genome[i]);
                }
            }

            solutionList[start + 2].Genome = child1Tour;
            solutionList[start + 3].Genome = child2Tour;

            _problem.EvaluateSolution(solutionList[start + 2]);
            _problem.EvaluateSolution(solutionList[start + 3]);

            _workDone++;

        }

        static void SwapInt(ref int lhs, ref int rhs)
        {
            int temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        void Shuffle()
        {
            int n = solutionList.Count();
            while (n > 1)
            {
                n--;
                int k = EvolutionHelper.rand(n + 1);
                Solution value = solutionList[k];
                solutionList[k] = solutionList[n];
                solutionList[n] = value;
            }
        }

        private void Mutate()
        {
            foreach (Solution s in solutionList)
            {
                if (EvolutionHelper.chance(EvolutionHelper.probabilityOfSolutionMutation))
                {
                    s.Mutate();
                }
            }
        }



        
    }
}
