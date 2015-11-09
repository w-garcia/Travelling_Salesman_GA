using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelling_salesman
{
    class indexToDouble
    {
        public int index;
        public double order;

        public indexToDouble(int i, double p)
        {
            // TODO: Complete member initialization
            index = i;
            order = p;
        }

    }
    class City
    {
        public double x;
        public double y;

        public City(double tx, double ty)
        {
            x = tx;
            y = ty;
        }

    }

    class Problem
    {
        public List<City> cityMatrix = new List<City>();

        private static int _size = 100;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        } 

        private int CompareValue(indexToDouble x, indexToDouble y)
        {
            return x.order.CompareTo(y.order);
        }

        static int CompareValue(double lhs, double rhs)
        {
            return lhs.CompareTo(rhs);
        }

        public Problem()
        {
            GenrateCityMatrix();
        }

        private void GenrateCityMatrix()
        {
            cityMatrix.Clear();
            for (int i = 0; i < _size; i++)
            {
                cityMatrix.Add(new City(EvolutionHelper.randDouble(1000), EvolutionHelper.randDouble(1000)));
            }
        }

        public void EvaluateSolution(Solution s)
        {
            double distanceTravelled = 0;

            List<indexToDouble> sortedListByOrder = new List<indexToDouble>();

            for (int i = 0; i < _size; i++)
            {
                sortedListByOrder.Add(new indexToDouble(i, s.Genome[i]));
            }

            sortedListByOrder.Sort(CompareValue);

            for (int i = 1; i < sortedListByOrder.Count; i++)
            {

                distanceTravelled += DistanceFromLastCity(cityMatrix[sortedListByOrder[i - 1].index], cityMatrix[sortedListByOrder[i].index]);

            }
            distanceTravelled += DistanceFromLastCity(cityMatrix[_size-1], cityMatrix[0]);

            s.Fitness = distanceTravelled;
        }

        static private double DistanceFromLastCity(City lastCityVisited, City currentCityVisited)
        {
            double x1, x2, y1, y2;
            x1 = lastCityVisited.x; y1 = lastCityVisited.y;
            x2 = currentCityVisited.x; y2 = currentCityVisited.y;

            double dx = x2 - x1;
            double dy = y2 - y1;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

    }
}
