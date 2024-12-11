
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

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3;
                File.AppendAllText(path, string.Format("{0:F2}", Math.Round(y, 2)) + Environment.NewLine);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
