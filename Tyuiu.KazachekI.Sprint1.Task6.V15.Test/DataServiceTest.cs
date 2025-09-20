using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task6.V15.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckLettersCount_MoreLetters()
        {
            DataService ds = new DataService();

            string value = "Hello, World! 123";
            bool wait = true; 

            bool res = ds.CheckLettersCount(value);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckLettersCount_MoreSymbols()
        {
            DataService ds = new DataService();

            string value = "!!! @@@ ### $$$";
            bool wait = false; 

            bool res = ds.CheckLettersCount(value);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckLettersCount_EqualCount()
        {
            DataService ds = new DataService();

            string value = "abc123!@#";
            bool wait = false; 

            bool res = ds.CheckLettersCount(value);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckLettersCount_OnlyLetters()
        {
            DataService ds = new DataService();

            string value = "HelloWorld";
            bool wait = true; 

            bool res = ds.CheckLettersCount(value);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckLettersCount_EmptyString()
        {
            DataService ds = new DataService();

            string value = "";
            bool wait = false; 

            bool res = ds.CheckLettersCount(value);

            Assert.AreEqual(wait, res);
        }
    }
}