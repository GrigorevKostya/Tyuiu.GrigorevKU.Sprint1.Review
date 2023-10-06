using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint1.TaskReview.V14.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.TaskReview.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double wait = 2.536;
            double res = ds.Calculate(1, 1);
            Assert.AreEqual(wait, res);
        }
    }
}
