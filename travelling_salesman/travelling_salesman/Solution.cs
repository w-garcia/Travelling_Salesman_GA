using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace travelling_salesman
{
    class Solution : IEquatable<Solution>, IComparable<Solution>
    {
        private List<double> _genome = new List<double>();
        private double _fitness;

        #region public properties

        public double Fitness
        {
            get { return _fitness; }
            set { _fitness = value; }
        }

        public List<double> Genome
        {
            get { return _genome; }
            set { _genome = value; }
        }

        #endregion

        #region interface overrides
        // Default comparer Solution (higher fitness on top)
        public int CompareTo(Solution compareSol)
        {
            // A null value means that this object is smaller.
            if (compareSol == null)
                return 1;

            else
                return _fitness.CompareTo(compareSol._fitness);
        }
        public bool Equals(Solution other)
        {
            if (other == null) return false;
            return (this._fitness.Equals(other._fitness));
        }

        static public bool operator <(Solution rhs, Solution lhs)
        {
            return rhs._fitness < lhs._fitness;
        }

        static public bool operator >(Solution rhs, Solution lhs)
        {
            return rhs._fitness > lhs._fitness;
        }

        #endregion

        public Solution()
        {
            RandomizeGenome();
            _fitness = 99999999999999999;
        }

        public Solution(Solution s)
        {
            _genome = s.Genome;
            _fitness = s.Fitness;

        }
        private void RandomizeGenome()
        {
            _genome.Clear();
            for (int i = 0; i < 100; i++)
            {
                _genome.Add(EvolutionHelper.randDouble(100));
              
            }
        }

        public void Mutate()
        {
            int randNumCitiesToFlip = EvolutionHelper.rand(100);
            for (int i = 0; i < randNumCitiesToFlip; i++)
            {
                int randIndex = EvolutionHelper.rand(100);
                _genome[randIndex] = EvolutionHelper.randDouble(100);
            }
        }
    }
}
