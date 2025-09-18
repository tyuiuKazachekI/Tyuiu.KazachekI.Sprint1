using Tyuiu.KazachekI.Sprint1.Task0.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Казачек Иван | ИСТНб-25-1";

Console.WriteLine("**************************************************");
Console.WriteLine("* Спринт #1");
Console.WriteLine("* Темв: Базовые навыки работы в C#");
Console.WriteLine("* Вариант #15");
Console.WriteLine("* Задание #1");
Console.WriteLine("Выполнил: Казачек Иван | ИСТНб-25-1");
Console.WriteLine("**************************************************");
Console.WriteLine("* УСЛОВИЕ:");
Console.WriteLine("* Написать программу, которая вычисляет выражение 20 - (2*2-8) и печатает результат на экране.");
Console.WriteLine("**************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine("20 - (2*2-8)");
Console.WriteLine("**************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:");
Console.WriteLine(ds.Calculate());
Console.ReadLine();
