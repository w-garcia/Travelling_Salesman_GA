using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelling_salesman
{
    class GeneticAlgorithm
    {
        private Problem _problem;

        private Population _population;

        #region prop

        public Problem Problem
        {
            get { return _problem; }
            set { _problem = value; }
        }

        public Population Population
        {
            get { return _population; }
            set { _population = value; }
        }
        #endregion 


        public GeneticAlgorithm()
        
        {
            _problem = new Problem();
            _population = new Population(_problem);
        }

        public void reset() { _population = new Population(new Problem()); }
    }
}
