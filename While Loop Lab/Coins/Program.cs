using System;

namespace Coins
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double rest = double.Parse(Console.ReadLine());
            int moneyBack = (int)Math.Round(rest * 100);
           
            int counter = 0;

            while (moneyBack != 0)
            {
                if(moneyBack >= 200)
                {
                    moneyBack -= 200;
                    counter++;
                }
                else if(moneyBack >= 100)
                {
                    moneyBack -= 100;
                    counter++;
                }
                else if (moneyBack >= 50)
                {
                    moneyBack -= 50;
                    counter++;
                }
                else if (moneyBack >= 20)
                {
                    moneyBack -= 20;
                    counter++;
                }
                else if (moneyBack >= 10)
                {
                    moneyBack -= 10;
                    counter++;
                }
                else if (moneyBack >= 5)
                {
                    moneyBack -= 5;
                    counter++;
                }
                else if (moneyBack >= 2)
                {
                    moneyBack -= 2;
                    counter++;
                }
                else if (moneyBack >= 1)
                {
                    moneyBack -= 1;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
