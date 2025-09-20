using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task7.V4.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 10;

            // Вычисляем ожидаемый результат вручную
            double sqrtX = Math.Sqrt(4); // 2
            double part1 = Math.Log(10 - 2); // ln(8) ≈ 2.07944
            double denominator = 4 + (16 / 4); // 4 + 4 = 8
            double part2 = 4 - (10 / 8); // 4 - 1.25 = 2.75
            double wait = Math.Round(2.07944 * 2.75, 3); // ≈ 5.718

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res, 0.001); // Допустимая погрешность
        }

        [TestMethod]
        public void ValidCalculateWithDifferentValues()
        {
            DataService ds = new DataService();

            double x = 9;
            double y = 15;

            // Проверяем, что метод не выбрасывает исключение
            // и возвращает корректный результат
            double res = ds.Calculate(x, y);

            // Просто проверяем, что результат является числом
            Assert.IsFalse(double.IsNaN(res));
            Assert.IsFalse(double.IsInfinity(res));
        }
    }
}