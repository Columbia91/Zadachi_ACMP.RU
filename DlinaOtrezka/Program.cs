using System;
using System.IO;
using System.Threading;

namespace DlinaOtrezka
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            string str = sr.ReadToEnd();
            string[] str2 = str.Split(' ');
            int[] numbs = new int[str2.Length];
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = int.Parse(str2[i]);
            }

            double length = Math.Sqrt(Math.Pow((numbs[2] - numbs[0]), 2) + Math.Pow((numbs[3] - numbs[1]), 2));

            sw.Write(length);
            sw.Close();
        }
    }
}
