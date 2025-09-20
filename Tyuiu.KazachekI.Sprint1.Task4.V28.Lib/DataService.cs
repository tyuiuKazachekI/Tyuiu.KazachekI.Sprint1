using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KazachekI.Sprint1.Task4.V28.Lib
{
    public class DataService : ISprint1Task4V28
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Cos(60 * Math.PI / 2);
            double denominator = Math.Exp(2 * x + y);
            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}