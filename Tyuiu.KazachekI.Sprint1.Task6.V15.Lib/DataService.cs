using System;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KazachekI.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            int letterCount = 0;
            int symbolCount = 0;

            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else if (!char.IsWhiteSpace(c)) 
                {
                    symbolCount++;
                }
            }

            return letterCount > symbolCount;
        }
    }
}