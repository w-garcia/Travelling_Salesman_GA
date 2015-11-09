using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelling_salesman
{
    static class EvolutionHelper
    {
        static Random random = new Random();

        static public int rand(int Emax)
        {
            return random.Next(Emax);
        }

        static public double randDouble(double Emax)
        {
            return random.NextDouble() * Emax;
        }

        static public KeyValuePair<int, int> randintKVP(int Emax)
        {
            return new KeyValuePair<int, int>(random.Next(Emax), random.Next(Emax));
        }

        static public int populationSize = 10000;
        public static double probabilityOfSolutionMutation = 0.03;

        public static bool chance(double p)
        {
            return random.NextDouble() < p;
        }
    }
}
