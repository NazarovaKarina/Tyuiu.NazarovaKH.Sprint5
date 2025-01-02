﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NazarovaKH.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double fx = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - (3.0 / 2) * x;
            fx = Math.Round(fx, 3);
            File.WriteAllText(path, Convert.ToString(fx));
            return path;
        }
    }
}
