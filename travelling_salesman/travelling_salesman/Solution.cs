using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace travelling_salesman
{
    class Solution : IEquatable<Solution>, IComparable<Solution>
    {
        private List<KeyValuePair<int, double>> genome = new List<KeyValuePair<int,double>>();
        private double _fitness;
        private double _distanceTravelled;

        #region public properties

        public double DistanceTravelled
        {
            get { return _distanceTravelled; }
            set { _distanceTravelled = value; }
        }

        public double Fitness
        {
            get { return _fitness; }
            set { _fitness = value; }
        }

        public List<KeyValuePair<int, double>> Genome
        {
            get { return genome; }
            set { genome = value; }
        }

        #endregion

        #region interface overrides
        // Default comparer Solution (higher fitness on top)
        public int CompareTo(Solution compareSol)
        {
            // A null value means that this object is smaller.
            if (compareSol == null)
                return -1;

            else
                return compareSol._fitness.CompareTo(this._fitness);
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
            _fitness = 0.0;
        }

        private void RandomizeGenome()
        {
            genome.Clear();
            for (int i = 0; i < 100; i++)
            {
                genome.Add(new KeyValuePair<int, double>(i, EvolutionHelper.randDouble()));
              
            }
        }

        public void Mutate()
        {
            //throw new NotImplementedException();
        }
    }
}
