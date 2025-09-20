using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTriangleArea()
        {
            DataService ds = new DataService();

            double x1 = -2;
            double y1 = 5;
            double x2 = 1;
            double y2 = 7;
            double x3 = 5;
            double y3 = -3;

            double res = ds.TriangleArea(x1, y1, x2, y2, x3, y3);

            Assert.AreEqual(19.00, res);
        }
    }
}