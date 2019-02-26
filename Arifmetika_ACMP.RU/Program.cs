using System.IO;

namespace Arifmetika_ACMP.RU
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            string str = sr.ReadToEnd();
            string[] _str = str.Split(' ');
            int[] numbs = new int[_str.Length];

            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = int.Parse(_str[i]);
            }

            if (numbs[0] * numbs[1] == numbs[2]) sw.Write("YES");
            else sw.Write("NO");
            sw.Close();
        }
    }
}
