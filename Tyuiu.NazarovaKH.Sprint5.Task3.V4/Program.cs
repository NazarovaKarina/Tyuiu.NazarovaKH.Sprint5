using Tyuiu.NazarovaKH.Sprint5.Task3.V4.Lib;

namespace Tyuiu.NazarovaKH.Sprint5.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;

            var res = ds.SaveToFileTextData(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"* Файл: {ds.SaveToFileTextData(x)} ");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
