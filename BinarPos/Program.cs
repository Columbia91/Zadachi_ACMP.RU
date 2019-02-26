using System.IO;

namespace BinarPos
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter = 97, count = 0;
            StreamReader sr = new StreamReader("input.txt");
            string str = sr.ReadLine();
            
            using (StreamWriter sw = File.AppendText("output.txt"))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if(str[i].ToString() == 1.ToString())
                    {
                        sw.Write(((char)(letter + count)).ToString());
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
        }
    }
}
