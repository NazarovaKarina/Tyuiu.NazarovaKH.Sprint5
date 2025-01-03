using Tyuiu.NazarovaKH.Sprint5.Task4.V5.Lib;
using System.IO;
namespace Tyuiu.NazarovaKH.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\гыук\source\repos\Tyuiu.NazarovaKH.Sprint5\Tyuiu.NazarovaKH.Sprint5.Task4.V5\bin\Debug\net8.0\InPutDataFileTask4V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}