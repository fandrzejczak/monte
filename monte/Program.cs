using System;
using System.IO;

namespace monte
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 100000;
            int v = 0;

            double x, y, pi=0;
            Random r = new Random();
            for (int i = 1; i <= g; i++)
            {
                x = r.NextDouble();
                y = r.NextDouble();
                if ((x * x + y * y) <= 1)
                    v++;
                pi = 4 * (float)v / (float)i;
            }
            try
            {
                StreamWriter sw = new StreamWriter("C:\\monte\\monte.txt");
                sw.WriteLine(pi);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine(pi);
            Console.ReadLine();
        }
    }
}
