
using Tyuiu.NovikovAA.Sprint5.Task7.V28.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");


            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V28.txt");
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V28.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("находятся в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
