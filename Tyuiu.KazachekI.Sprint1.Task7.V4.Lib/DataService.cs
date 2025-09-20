using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KazachekI.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {

            // Первая часть: ln(y - √x)
            double part1 = Math.Log(y - Math.Sqrt(x));

            // Вторая часть: x - y/(x + x²/4)
            double denominator = x + (Math.Pow(x, 2) / 4);
            double part2 = x - (y / denominator);

            // Итоговый результат
            double result = part1 * part2;

            // Округляем до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}