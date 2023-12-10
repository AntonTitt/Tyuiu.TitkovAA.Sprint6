using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.TitkovAA.Sprint6.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService dt = new DataService();
            double[] z = new double[3];
            z[0] = -12.968;
            z[1] = -9;
            z[2] = -0.315;
            CollectionAssert.AreEqual(z, dt.GetMassFunction(-1, 1));

        }
    }
}
