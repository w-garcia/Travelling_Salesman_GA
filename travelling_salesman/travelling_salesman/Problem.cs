using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelling_salesman
{
    class Problem
    {
        public List<KeyValuePair<int, int>> cityMatrix = new List<KeyValuePair<int,int>>();

        static int CompareValue(KeyValuePair<int, double> lhs, KeyValuePair<int, double> rhs)
        {
            return lhs.Value.CompareTo(rhs.Value);
        }

        public Problem()
        {
            GenrateCityMatrix();
        }

        private void GenrateCityMatrix()
        {
            cityMatrix.Clear();
            for (int i = 0; i < 100; i++)
            {
                cityMatrix.Add(new KeyValuePair<int, int>(EvolutionHelper.rand(1000), EvolutionHelper.rand(1000)));
            }
        }

        public void EvaluateSolution(Solution s)
        {
            //double bonus = 1.0;
            //double score = 0.0;
            double distanceTravelled = 0;

            List<KeyValuePair<int, double>> sortedListByOrder = new List<KeyValuePair<int,double>>(s.Genome);
            sortedListByOrder.Sort(CompareValue);

            KeyValuePair<int, int> lastCityVisited = cityMatrix[sortedListByOrder[0].Key]; //first city to visit according to genome
            KeyValuePair<int, int> currentCityVisited;

            foreach (KeyValuePair<int, double> kvp in sortedListByOrder)
            {
                currentCityVisited = cityMatrix[kvp.Key];

                distanceTravelled += DistanceFromLastCity(lastCityVisited, currentCityVisited);

            }

            s.DistanceTravelled = distanceTravelled;

            int magnification = 100;

            s.Fitness = (1 / distanceTravelled) * magnification;
        }

        static private double DistanceFromLastCity(KeyValuePair<int, int> lastCityVisited, KeyValuePair<int, int> currentCityVisited)
        {
            int x1, x2, y1, y2;
            x1 = lastCityVisited.Key; y1 = lastCityVisited.Value;
            x2 = currentCityVisited.Key; y2 = currentCityVisited.Value;

            int dx = x2 - x1;
            int dy = y2 - y1;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }
    }
}
