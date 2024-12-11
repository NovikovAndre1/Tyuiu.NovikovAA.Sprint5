using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NovikovAA.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = 2.56;
            double res = (3 * Math.Pow(x, 3)) / Math.Sin(x);
            Math.Round(res, 3);
            return res;
        }
    }
}
