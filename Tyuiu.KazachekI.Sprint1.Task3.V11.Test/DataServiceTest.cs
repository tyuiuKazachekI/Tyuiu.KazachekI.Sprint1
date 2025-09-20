using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 3;

            double wait = 2.0 / 1 + 2.0 / 4 + 2.0 / 9; 
            wait = Math.Round(wait, 3);

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}