using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertCelsiusToKelvin()
        {
            DataService ds = new DataService();
            int value = 27; 
            var res = ds.ConvertCelsiusToKelvin(value);
            Assert.AreEqual(300, res);
        }
    }
}