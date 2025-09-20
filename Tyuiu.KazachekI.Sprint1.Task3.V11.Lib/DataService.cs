using System;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint1.Task3.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int i = startValue; i <= stopValue; i++)
            {

                sum += (double)value / (i * i);
            }

            return Math.Round(sum, 3);
        }


    }
}