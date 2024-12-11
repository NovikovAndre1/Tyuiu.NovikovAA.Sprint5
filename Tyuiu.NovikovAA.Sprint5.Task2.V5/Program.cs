
using Tyuiu.NovikovAA.Sprint5.Task2.V5.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { {9, 6, 6},
                                         {8, 7, 2 },
                                         {1, 7, 8 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            DataService ds = new DataService();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("Массив");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("********************************************************************");
            string res = ds.SaveToFileTextData(mtrx);


            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
