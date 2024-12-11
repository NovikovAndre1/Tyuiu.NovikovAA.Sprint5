
using Tyuiu.NovikovAA.Sprint5.Task3.V25.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3;

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
