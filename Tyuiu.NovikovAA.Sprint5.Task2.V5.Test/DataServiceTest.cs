
using Tyuiu.NovikovAA.Sprint5.Task2.V5.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            string path = @"C:\Users\é\source\repos\Tyuiu.NovikovAA.Sprint5\Tyuiu.NovikovAA.Sprint5.Task1.V10\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}