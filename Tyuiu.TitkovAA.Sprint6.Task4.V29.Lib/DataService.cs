using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TitkovAA.Sprint6.Task4.V29.Lib
{
    public class DataService : ISprint6Task4V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            double[] valueArray;
            int len = (stopValue - startValue) + 1, c = 0; ;
            valueArray = new double[len];
            double y;
            for(int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2);
                valueArray[c] = y;
                c++;
            }



            return valueArray;
        }
    }
}
