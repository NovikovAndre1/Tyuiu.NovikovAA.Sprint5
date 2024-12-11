using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            return File.ReadAllLines(path)
                     .Select(line => double.Parse(line))
                     .Select(num => Math.Round(num, 3))
                     .Where(num => num == Math.Floor(num))
                     .Max();
        }
    }
}
