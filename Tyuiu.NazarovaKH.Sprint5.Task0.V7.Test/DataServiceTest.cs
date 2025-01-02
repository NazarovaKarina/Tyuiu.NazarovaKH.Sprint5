using Tyuiu.NazarovaKH.Sprint5.Task0.V7.Lib;
using System.IO;
namespace Tyuiu.NazarovaKH.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\гыук\source\repos\Tyuiu.NazarovaKH.Sprint5\Tyuiu.NazarovaKH.Sprint5.Task0.V7\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}