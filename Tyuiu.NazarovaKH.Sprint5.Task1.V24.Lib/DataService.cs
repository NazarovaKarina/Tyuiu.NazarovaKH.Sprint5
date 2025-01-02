using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NazarovaKH.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((3 * Math.Cos(x)) / ((4 * x) - 0.5) + Math.Sin(x) - (5 * x) - 2), 2);
                strY = Convert.ToString(y);

                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
