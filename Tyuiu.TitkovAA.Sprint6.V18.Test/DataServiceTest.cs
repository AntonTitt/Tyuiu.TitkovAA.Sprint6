using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.TitkovAA.Sprint6.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(1.056, dt.Calculate(3));
        }
    }
}
