using System;

namespace Odd_Even_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumOdd = 0;
            double maxOdd = -1000;
            double minOdd = 1000;
            double sum = 0;
            double max = -1000;
            double min = 1000;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumOdd += number;

                    if(maxOdd < number)
                    {
                        maxOdd = number;
                    }
                    if(minOdd > number)
                    {
                        minOdd = number;
                    }

                    
                }
                else
                {
                    sum += number;

                    if (max < number)
                    {
                        max = number;
                    }
                    if (min > number)
                    {
                        min = number;
                    }

                }
            }
            if(sumOdd == 0.00 && sum == 0.00)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");

                Console.WriteLine($"EvenSum={sum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }

            else if(sumOdd == 0)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");

                Console.WriteLine($"EvenSum={sum:f2},");
                Console.WriteLine($"EvenMin={min:f2},");
                Console.WriteLine($"EvenMax={max:f2}");
            }
            else if(sum == 0)
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");

                Console.WriteLine($"EvenSum={sum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={sumOdd:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");


                Console.WriteLine($"EvenSum={sum:f2},");
                Console.WriteLine($"EvenMin={min:f2},");
                Console.WriteLine($"EvenMax={max:f2}");
            }

           

        }
    }
}
