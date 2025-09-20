using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task5.V3.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int k = 130985;
            int wait = 9; 

            int res = ds.Calculate(k);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithSmallNumber()
        {
            DataService ds = new DataService();

          
            int k = 99;
            int wait = 0; 
            int res = ds.Calculate(k);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWithThreeDigitNumber()
        {
            DataService ds = new DataService();

            // Тест с трехзначным числом
            int k = 123;
            int wait = 1; // третья цифра от конца - первая цифра

            int res = ds.Calculate(k);

            Assert.AreEqual(wait, res);
        }
    }
}