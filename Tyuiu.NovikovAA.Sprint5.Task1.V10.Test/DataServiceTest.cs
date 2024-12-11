
using Tyuiu.NovikovAA.Sprint5.Task1.V10.Lib;


namespace Tyuiu.NovikovAA.Sprint5.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            string path = @"C:\Users\é\source\repos\Tyuiu.NovikovAA.Sprint5\Tyuiu.NovikovAA.Sprint5.Task1.V10\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}