
using Tyuiu.NovikovAA.Sprint5.Task6.V6.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");


            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V6.txt");

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
