using System.IO;
using Tyuiu.NazarovaKH.Sprint5.Task4.V5.Lib;
namespace Tyuiu.NazarovaKH.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\гыук\source\repos\Tyuiu.NazarovaKH.Sprint5\Tyuiu.NazarovaKH.Sprint5.Task4.V5\bin\Debug\net8.0\InPutDataFileTask4V5.txt";
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
