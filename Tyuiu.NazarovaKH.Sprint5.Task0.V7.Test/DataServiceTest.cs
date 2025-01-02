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

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fl = new FileInfo(path);
            bool fle = fl.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fle);
        }
    }
}