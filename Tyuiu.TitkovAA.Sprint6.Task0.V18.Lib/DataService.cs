using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TitkovAA.Sprint6.V18.Lib
{
    public class DataService : ISprint6Task0V18
    {

        public double Calculate(int x)
        {
            double t = 0;
            t = Math.Round((double)(x * x * x - 8) / (double)(2 * x * x), 3);
            return t;
        }


    }
}
