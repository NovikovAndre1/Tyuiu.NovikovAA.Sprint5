
using Tyuiu.NovikovAA.Sprint5.Task0.V18.Lib;


namespace Tyuiu.NovikovAA.Sprint5.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            string result = ds.SaveToFileTextData(x);

            if (result.StartsWith("Ошибка:"))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Результат сохранен в: {result}");
            }
        }
    }
}
