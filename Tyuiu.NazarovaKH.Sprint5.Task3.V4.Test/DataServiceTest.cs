using Tyuiu.NazarovaKH.Sprint5.Task3.V4.Lib;
using System.IO;
namespace Tyuiu.NazarovaKH.Sprint5.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTestMethod1SaveToFileTextData()
        {
            string path = @"C:\Users\гыук\source\repos\Tyuiu.NazarovaKH.Sprint5\Tyuiu.NazarovaKH.Sprint5.Task3.V4\bin\Debug\net8.0\OutPutFileTask3.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}