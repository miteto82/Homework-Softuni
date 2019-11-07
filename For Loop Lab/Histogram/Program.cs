using System;

namespace DivideWithoutRemainder
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

            for (int i = 0; i < n; i++)
            {
                counter++;

                int num = int.Parse(Console.ReadLine());

                if(num % 2 == 0)
                {
                    p1++;
                }
                if(num % 3 == 0)
                {
                    p2++;
                }
                if(num % 4 == 0)
                {
                    p3++;
                }

            }

           

            Console.WriteLine($"{(100*p1)/counter:f2}%");
            Console.WriteLine($"{(100*p2)/counter:f2}%");
            Console.WriteLine($"{(100*p3)/counter:f2}%");
        }
    }
}
