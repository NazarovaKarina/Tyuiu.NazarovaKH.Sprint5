using Tyuiu.NazarovaKH.Sprint5.Task7.V4.Lib;
namespace Tyuiu.NazarovaKH.Sprint5.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
            Console.WriteLine("******************************************************************************************");

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
            Console.WriteLine("******************************************************************************************");

            string path = @"C:DataSprint5\InPutDataFileTask7V4.txt";
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат: " + res);
            Console.ReadLine();
        }
    }
}
