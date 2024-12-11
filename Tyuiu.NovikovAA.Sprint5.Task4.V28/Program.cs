
using Tyuiu.NovikovAA.Sprint5.Task4.V28.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");


            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V28.txt");

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
