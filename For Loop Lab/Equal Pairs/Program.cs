using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diff = 0;
            int firstPair = 0;
           

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            firstPair = a + b;

            for (int i = 0; i < n-1; i++)
            {
                firstPair = a + b;

                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if(diff < Math.Abs(firstPair - (a + b)))
                {
                    diff = Math.Abs(firstPair - (a + b));
                }
                
               
            }

            

            if(diff == 0)
            {
                Console.WriteLine($"Yes, value={firstPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
