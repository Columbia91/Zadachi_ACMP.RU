using System;
using System.IO;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            int N = int.Parse(sr.ReadLine());
            int count = 0;

            if (N <= Math.Pow(10, 4))
            {
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        count += i;
                    }   
                }
                else
                {
                    for (int i = N; i <= 1; i++)
                    {
                        count += i;
                    }
                }
                sw.Write(count);
                sw.Close();
            }
        }
    }
}
