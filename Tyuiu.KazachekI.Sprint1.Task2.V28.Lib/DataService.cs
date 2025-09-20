using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KazachekI.Sprint1.Task2.V28.Lib
{
    public class DataService : ISprint1Task2V28 // Реализуем правильный интерфейс
    {
        public int ConvertCelsiusToKelvin(int value)
        {
            // Формула: K = C + 273
            return value + 273;
        }
    }
}