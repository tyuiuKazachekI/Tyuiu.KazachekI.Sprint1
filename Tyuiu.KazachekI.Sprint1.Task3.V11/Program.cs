using System;
using Tyuiu.KazachekI.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KazachekI.Sprint1.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Казачек Иван | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая вычисляет площадь треугольника, если       *");
            Console.WriteLine("* известны координаты его углов. Ответ округлите до 3 знаков после запятой.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Запрос координат у пользователя
            Console.WriteLine("Введите координаты углов:");

            Console.Write("x1 -> ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 -> ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2 -> ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2 -> ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3 -> ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y3 -> ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вычисление и вывод результата
            double result = ds.TriangleArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine($"Площадь треугольника: {result} кв.см");

            Console.ReadLine();
        }
    }
}