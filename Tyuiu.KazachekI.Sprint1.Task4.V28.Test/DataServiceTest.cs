using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task4.V28.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double numerator = Math.Cos(60 * Math.PI / 2);
            double denominator = Math.Exp(2 * x + y);
            double wait = Math.Round(numerator / denominator, 3);

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}