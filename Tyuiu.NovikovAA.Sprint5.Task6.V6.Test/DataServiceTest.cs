
using Tyuiu.NovikovAA.Sprint5.Task6.V6.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\�\source\repos\Tyuiu.NovikovAA.Sprint5\Tyuiu.NovikovAA.Sprint5.Task1.V10\bin\Debug\net8.0\InPutDataFileTask6V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}