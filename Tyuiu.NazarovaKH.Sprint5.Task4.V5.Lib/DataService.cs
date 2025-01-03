using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.NazarovaKH.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ",";
            string strX = str.Replace(".", ",");
            double parsedValue;
            double.TryParse(strX, NumberStyles.Any, nfi, out parsedValue);
            double res = Math.Round(4.26 * parsedValue / Math.Sin(parsedValue), 3);
            return res;
        }
    }
}
