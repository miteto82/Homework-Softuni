using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washMshine = double.Parse(Console.ReadLine());
            double toyMoney = double.Parse(Console.ReadLine());

            double BirthDayMoney = 0;
            double sumToys = 0;
            int counter = 0;
            

            for (int i = 1; i <= years; i++)
            {
                if(i % 2 == 0)
                {
                    counter++;
                    BirthDayMoney += 10 * counter;
                    
                }
                else
                {
                    sumToys += toyMoney;
                }
            }

            BirthDayMoney += sumToys - counter;
            BirthDayMoney -= washMshine;

            if(BirthDayMoney >= 0)
            {
                Console.WriteLine($"Yes! {BirthDayMoney:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(BirthDayMoney):f2}");
            }
        }
    }
}
