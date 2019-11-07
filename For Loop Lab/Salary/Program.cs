using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string sites = Console.ReadLine();

                if(sites == "Facebook")
                {
                    salary -= 150;
                }
                else if(sites == "Instagram")
                {
                    salary -= 100;
                }
                else if(sites == "Reddit")
                {
                    salary -= 50;
                }

                if(salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
