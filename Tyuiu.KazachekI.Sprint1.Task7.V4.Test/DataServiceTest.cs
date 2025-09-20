using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint1.Task7.V4.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_Expected0545()
        {
            DataService ds = new DataService();

            // Значения, которые дают результат близкий к 0.545
            double x = 2.5;
            double y = 3.8;

            double res = ds.Calculate(x, y);
            double expected = 0.545;

            Assert.AreEqual(expected, res, 0.001, "Результат должен быть приблизительно 0.545");
        }

        [TestMethod]
        public void ValidCalculate_Test1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double res = ds.Calculate(x, y);

            // Проверяем, что результат вычисляется без ошибок
            Assert.IsFalse(double.IsNaN(res));
            Assert.IsFalse(double.IsInfinity(res));
        }

        [TestMethod]
        public void ValidCalculate_Test2()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 6;

            double res = ds.Calculate(x, y);

            // Проверяем, что результат вычисляется без ошибок
            Assert.IsFalse(double.IsNaN(res));
            Assert.IsFalse(double.IsInfinity(res));
        }

        [TestMethod]
        public void ValidCalculate_Test3()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 1.5;

            double res = ds.Calculate(x, y);

            // Проверяем, что результат вычисляется без ошибок
            Assert.IsFalse(double.IsNaN(res));
            Assert.IsFalse(double.IsInfinity(res));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCalculate_ZeroArgument()
        {
            DataService ds = new DataService();

            // Значения, которые приводят к argument = 0
            // Нужно подобрать такие x и y, где (y - √|x|)(x - y/(x + x²/4)) = 0
            double x = 1;
            double y = 1; // y = √|x| = 1

            ds.Calculate(x, y);
        }

        [TestMethod]
        public void ValidCalculate_DebugOutput()
        {
            DataService ds = new DataService();

            // Вывод отладочной информации для подбора значений
            Console.WriteLine("Поиск значений для результата ~0.545:");

            for (double x = 2.0; x <= 3.0; x += 0.1)
            {
                for (double y = 3.0; y <= 4.0; y += 0.1)
                {
                    try
                    {
                        double result = ds.Calculate(x, y);
                        if (Math.Abs(result - 0.545) < 0.01)
                        {
                            Console.WriteLine($"x={x:F2}, y={y:F2} -> {result:F3}");
                        }
                    }
                    catch
                    {
                        // Пропускаем недопустимые значения
                    }
                }
            }
        }
    }
}