using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TitkovAA.Sprint6.Task2.V19.Lib
{
    public class DataService : ISprint6Task2V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] valarray = new double[(stopValue - startValue) + 1];


            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != -1)
                {
                    y = Math.Round(Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x, 2);

                    valarray[c] = y;
                }
                else
                {
                    valarray[c] = 0;
                }
                c++;
            }

            return valarray;
        }
    }
}
