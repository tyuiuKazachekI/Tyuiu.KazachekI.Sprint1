using System;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.KazachekI.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            // Вычисляем выражение: ln|(y - √|x|)(x - y/(x + x²/4))|

            // Модуль x для корня
            double absX = Math.Abs(x);

            // Первая часть: (y - √|x|)
            double part1 = y - Math.Sqrt(absX);

            // Вторая часть: (x - y/(x + x²/4))
            double denominator = x + (Math.Pow(x, 2) / 4);
            double part2 = x - (y / denominator);

            // Аргумент логарифма: (y - √|x|)(x - y/(x + x²/4))
            double argument = part1 * part2;

            // Берем модуль аргумента для логарифма
            double absArgument = Math.Abs(argument);

            // Проверяем, что аргумент не равен 0 (ln(0) не определен)
            if (absArgument == 0)
            {
                throw new ArgumentException("Аргумент логарифма не может быть равен 0");
            }

            // Проверяем, что аргумент положительный (для вещественного логарифма)
            if (absArgument <= 0)
            {
                throw new ArgumentException("Аргумент логарифма должен быть положительным");
            }

            // Итоговый результат: ln|argument|
            double result = Math.Log(absArgument);

            // Округляем до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}