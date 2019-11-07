using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 0;

            while (command != "Going home")
            {
               int steps = int.Parse(command);

                counter += steps;

                if(counter >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    return;
                }

                command = Console.ReadLine();
            }

            int leftSteps = 10000 - counter;

            int input = int.Parse(Console.ReadLine());

            if (leftSteps-input <= 0)
            {
                Console.WriteLine("Goal reached! Good job!");
                return;
            }
           
                Console.WriteLine($"{leftSteps-input} more steps to reach goal.");
            

            
        }
    }
}
