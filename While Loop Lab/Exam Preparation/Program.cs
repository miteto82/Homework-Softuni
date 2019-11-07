using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int noGoodGreads = int.Parse(Console.ReadLine());

            int count = 0;
            string lastProblem = "";
            double avarScore = 0;
            int poorGreads = 0;

            while (noGoodGreads != poorGreads)
            {
                string nameProblem = Console.ReadLine();

                if(nameProblem == "Enough")
                {
                    avarScore /= count;

                    Console.WriteLine($"Average score: {avarScore:f2}");
                    Console.WriteLine($"Number of problems: {count}");
                    Console.WriteLine($"Last problem: {lastProblem}");

                    return;
                }

                int gread = int.Parse(Console.ReadLine());

                if (gread < 5)
                {
                    poorGreads++;
                }
                count++;
                lastProblem = nameProblem;
                avarScore += gread;
                
            }

            Console.WriteLine($"You need a break, {poorGreads} poor grades.");

        }
    }
}
