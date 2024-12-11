using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double result = double.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Разделяем строку на отдельные элементы
                        var values = line.Split();

                        foreach (var valueStr in values)
                        {
                            // Преобразуем строку в число, используя InvariantCulture
                            double value = Math.Round(double.Parse(valueStr, CultureInfo.InvariantCulture), 3);

                            // Проверяем, является ли текущее значение максимальным
                            if (value > result)
                            {
                                result = value;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
