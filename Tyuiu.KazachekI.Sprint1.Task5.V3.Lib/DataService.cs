using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KazachekI.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            if (k < 100)
            {
                return 0; 
            }

            return (k / 100) % 10;
        }
    }
}