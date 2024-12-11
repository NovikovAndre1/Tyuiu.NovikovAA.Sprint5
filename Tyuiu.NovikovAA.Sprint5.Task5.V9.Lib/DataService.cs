using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double maxInteger = double.MinValue;
            foreach (string line in File.ReadAllLines(path))
            {
                double number = double.Parse(line);
                double roundedNumber = Math.Round(number, 3);
                if (roundedNumber == Math.Floor(roundedNumber))
                {
                    maxInteger = Math.Max(maxInteger, roundedNumber);
                }
            }
            return maxInteger;
        }
    }
}
