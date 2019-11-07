using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            double DesisMoney = double.Parse(Console.ReadLine());
            int maxDays = 0;
            int days = 0;

            while (days != 5)
            {
                string action = Console.ReadLine();
                double moneyAction = double.Parse(Console.ReadLine());
                maxDays++;

                if(action == "spend")
                {
                    DesisMoney -= moneyAction;

                    if (DesisMoney <= 0)
                    {
                        DesisMoney = 0;
                    }

                    days++;
                }
                else 
                {
                    DesisMoney += moneyAction;
                    if(DesisMoney >= vacationCost)
                    {
                        Console.WriteLine($"You saved the money for {maxDays} days.");
                        return;
                    }

                    days = 0;
                }
                
               
            }
            
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(maxDays);
        }
    }
}
