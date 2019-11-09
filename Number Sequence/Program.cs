using System;

namespace Number_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = -1000;
            int min = 1000;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(max < number)
                {
                    max = number;
                }

                if(min > number)
                {
                    min = number;
                }


            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");

        }
    }
}
