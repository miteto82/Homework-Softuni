using System;

namespace Histograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double counter = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                counter++;

                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2++;
                }
                else if (num >=400 && num < 600)
                {
                    p3++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }

            }

            Console.WriteLine($"{(100 * p1) / counter:f2}%");
            Console.WriteLine($"{(100 * p2) / counter:f2}%");
            Console.WriteLine($"{(100 * p3) / counter:f2}%");
            Console.WriteLine($"{(100 * p4) / counter:f2}%");
            Console.WriteLine($"{(100 * p5) / counter:f2}%");
        }
    }
}
