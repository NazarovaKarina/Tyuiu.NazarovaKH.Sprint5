using Tyuiu.NazarovaKH.Sprint5.Task6.V2.Lib;
namespace Tyuiu.NazarovaKH.Sprint5.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V2.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество русских букв = " + res);
            Console.ReadKey();
        }
    }
}
