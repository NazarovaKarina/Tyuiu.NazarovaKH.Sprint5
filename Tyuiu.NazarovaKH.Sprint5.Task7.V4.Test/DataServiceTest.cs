using Tyuiu.NazarovaKH.Sprint5.Task7.V4.Lib;
using System.IO;
namespace Tyuiu.NazarovaKH.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\Users\гыук\source\repos\Tyuiu.NazarovaKH.Sprint5\Tyuiu.NazarovaKH.Sprint5.Task7.V4\bin\Debug\net8.0\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}