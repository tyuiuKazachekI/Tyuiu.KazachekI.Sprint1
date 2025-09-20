using Tyuiu.KazachekI.Sprint1.Task1.V18.Lib;
namespace Tyuiu.KazachekI.Sprint1.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.00;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-2, res);
        }
    }
}
