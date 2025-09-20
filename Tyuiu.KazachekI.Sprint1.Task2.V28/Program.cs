using Tyuiu.KazachekI.Sprint1.Task2.V28.Lib;
using System;

namespace Tyuiu.KazachekI.Sprint1.Task2.V28
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известна температура в градусах Цельсия. Перевести температуру в        *");
            Console.WriteLine("* градусы Кельвина.                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите температуру в градусах Цельсия: ");
            int tempC = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int tempK = ds.ConvertCelsiusToKelvin(tempC);
            Console.WriteLine($"Температура в градусах Кельвина = {tempK}");

            Console.ReadLine();
        }
    }
}