using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double maxValue = double.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Преобразуем строку в число
                        double value = Math.Round(Convert.ToDouble(line), 3);

                        // Проверяем, является ли текущее значение максимальным
                        if (value > maxValue)
                        {
                            maxValue = value;
                        }
                    }
                }
            }
            return maxValue;

        }
    }
}
