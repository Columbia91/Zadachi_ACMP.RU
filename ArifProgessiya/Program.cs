using System.IO;

namespace ArifProgessiya
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            string str = sr.ReadLine();
            string[] str2 = str.Split(' ');
            int[] numbs = new int[str2.Length];
            for (int i = 0; i < numbs.Length; i++)
            {
                numbs[i] = int.Parse(str2[i]);
            }
            int unknownNumb = numbs[0] + (numbs[2] - 1) * (numbs[1] - numbs[0]);
            sw.Write(unknownNumb);
            sw.Close();
        }
    }
}
