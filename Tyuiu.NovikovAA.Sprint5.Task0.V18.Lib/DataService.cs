
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovAA.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            try
            {
                double y;
                if (x + x * x <= 0)
                {
                    return $"Ошибка: Аргумент должен быть таким, чтобы x + x^2 > 0";
                }
                y = x / Math.Sqrt(x * x + x);

                string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
                File.WriteAllText(filePath, y.ToString("F3"));
                return filePath;
            }
            catch (Exception ex)
            {
                return $"Произошла неизвестная ошибка: {ex.Message}";
            }
        }
    }
}
