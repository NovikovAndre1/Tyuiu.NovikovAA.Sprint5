using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.NovikovAA.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            string pathSafeFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V28.txt");

            FileInfo fileInfo = new FileInfo(pathSafeFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSafeFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for ( int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != ' '))
                        {
                            strLine = strLine + line[i];
                        }
                    }

                    File.AppendAllText(pathSafeFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSafeFile;
        }
    }
}
