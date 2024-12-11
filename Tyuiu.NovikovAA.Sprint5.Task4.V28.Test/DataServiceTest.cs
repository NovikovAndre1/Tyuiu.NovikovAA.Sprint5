
using System.IO;
using Tyuiu.NovikovAA.Sprint5.Task4.V28.Lib;

namespace Tyuiu.NovikovAA.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\é\source\repos\Tyuiu.NovikovAA.Sprint5\Tyuiu.NovikovAA.Sprint5.Task1.V10\bin\Debug\net8.0\";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}