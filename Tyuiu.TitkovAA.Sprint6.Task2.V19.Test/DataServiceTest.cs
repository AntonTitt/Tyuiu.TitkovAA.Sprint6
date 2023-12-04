using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint6.Task2.V19.Lib;
namespace Tyuiu.TitkovAA.Sprint6.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int StartVal = -5, stopVal = 5;
            int length = stopVal - StartVal + 1;
            double[] valexpectarr = new double[length];
            valexpectarr = new double[length];
            valexpectarr[0] = -15.44;
            valexpectarr[1] = -10.93;
            valexpectarr[2] = -7.22;
            valexpectarr[3] = -5.04;
            valexpectarr[4] = 0;
            valexpectarr[5] = -0.3;
            valexpectarr[6] = 2.57;
            valexpectarr[7] = 6.4;
            valexpectarr[8] = 10.04;
            valexpectarr[9] = 12.72;
            valexpectarr[10] = 14.68;
            CollectionAssert.AreEqual(valexpectarr, dt.GetMassFunction(StartVal, stopVal));

        }
    }
}
