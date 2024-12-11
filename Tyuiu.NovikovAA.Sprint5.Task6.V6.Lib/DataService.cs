using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.NovikovAA.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            foreach (char c in path)
            {
                if ('а' <= c && c <= 'я') // Проверка, является ли символ строчной русской буквой
                {
                    count++;
                }
            }

            return count;

        }
    }
}
