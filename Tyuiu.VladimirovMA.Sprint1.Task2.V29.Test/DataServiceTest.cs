using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.VladimirovMA.Sprint1.Task2.V29.Lib;

namespace Tyuiu.VladimirovMA.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int seconds = 1200;
            int res = ds.ConvertSecondsToHours(seconds);
            Assert.AreEqual(20, res);
        }
    }
}
