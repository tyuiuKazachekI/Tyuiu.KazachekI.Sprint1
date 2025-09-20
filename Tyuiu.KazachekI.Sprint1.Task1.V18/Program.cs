using Tyuiu.KazachekI.Sprint1.Task1.V18.Lib;
using tyuiu.cources.programming.interfaces;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Казачек Иван | ИСТНб-25-1";

Console.WriteLine("**************************************************");
Console.WriteLine("* Спринт #1");
Console.WriteLine("* Темв: Базовые навыки работы в C#");
Console.WriteLine("* Вариант #18");
Console.WriteLine("* Задание #1");
Console.WriteLine("Выполнил: Казачек Иван | ИСТНб-25-1");
Console.WriteLine("**************************************************");
Console.WriteLine("* УСЛОВИЕ:");
Console.WriteLine("* Написать программу, которая вычисляет выражение 20 - (2*2-8) и печатает результат на экране.");
Console.WriteLine("**************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine("**************************************************");
double x, y;
Console.WriteLine("Введите значение Х:");
x= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("**************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:");
Console.WriteLine("**************************************************");

Console.WriteLine(ds.Calculate(x,y));
Console.ReadLine();