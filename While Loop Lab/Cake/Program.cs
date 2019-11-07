using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int piaces = x * y;
            int sum = 0;

            string input = Console.ReadLine();
            int takePeaces = 0;

            while (input != "STOP")
            {
                takePeaces = int.Parse(input);
                sum += takePeaces;

                if(sum >= piaces)
                {
                    sum -= piaces;
                    Console.WriteLine($"No more cake left! You need {sum} pieces more.");
                    return;
                }

                input = Console.ReadLine();

            }

            piaces -= sum;

            Console.WriteLine($"{piaces} pieces are left.");
        }
    }
}
