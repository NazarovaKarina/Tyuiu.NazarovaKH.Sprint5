using Tyuiu.NazarovaKH.Sprint5.Task5.V17.Lib;
namespace Tyuiu.NazarovaKH.Sprint5.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма всех простых целых чисел равна = " + res);
            Console.ReadKey();
        }
    }
}
