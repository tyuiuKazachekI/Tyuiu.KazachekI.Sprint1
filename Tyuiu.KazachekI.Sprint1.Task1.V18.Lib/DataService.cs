using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KazachekI.Sprint1.Task1.V18.Lib
{
    public class DataService : ISprint1Task1V18
    {
        public double Calculate(double x, double y)
            { return (x * y) / (x + 1) - 3; }
    }
}
