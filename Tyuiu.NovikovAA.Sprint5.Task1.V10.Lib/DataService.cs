
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            if (fileExists) 
            { 
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 1;
                double y;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * Math.Cos(x) + 2) / denominator + Math.Cos(x) - 5 * x + 3;
                }
                File.AppendAllText(path, string.Format("{0:F2}", Math.Round(y, 2)) + Environment.NewLine);
            }
            return path;
        }
    }
}
