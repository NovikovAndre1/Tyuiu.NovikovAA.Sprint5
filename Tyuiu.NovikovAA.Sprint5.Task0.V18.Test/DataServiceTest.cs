
using Tyuiu.NovikovAA.Sprint5.Task0.V18.Lib;


namespace Tyuiu.NovikovAA.Sprint5.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string result = ds.SaveToFileTextData(3);
            Assert.IsTrue(result.StartsWith(Path.GetTempPath())); //Проверяем, начинается ли с пути к временным файлам
            Assert.IsTrue(File.Exists(result));
        }
    }
}