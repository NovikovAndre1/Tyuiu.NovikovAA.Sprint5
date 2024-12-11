using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            // Путь к файлу
            string filePath = "/app/data/AssesmentData/C#/Sprint5Task5/InPutDataFileTask5V9.txt";

            // Переменная для хранения максимального значения
            double maxValue = double.MinValue;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Разбиваем строку на отдельные элементы
                        var values = line.Split(' ');

                        foreach (var valueStr in values)
                        {
                            // Преобразуем строку в число
                            double value = Math.Round(Convert.ToDouble(valueStr), 3);

                            // Проверяем, является ли текущее значение максимальным
                            if (value > maxValue)
                            {
                                maxValue = value;
                            }
                        }
                    }
                }
            }
            return maxValue;
            // Выводим найденное максимальное значение
            Console.WriteLine($"Максимальное значение: {maxValue}");
        }
    }
}
