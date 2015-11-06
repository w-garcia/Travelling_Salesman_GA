using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelling_salesman
{
    class GeneticAlgorithm
    {
        public Population _population;

        public Population Population
        {
            get { return _population; }
            set { _population = value; }
        }

        public GeneticAlgorithm()
        
        {
            _population = new Population();
        }

        public void reset() { _population = new Population(); }
    }
}
