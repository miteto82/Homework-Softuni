using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string AniBook = Console.ReadLine();
            int countBook = int.Parse(Console.ReadLine());
            int count = 0;

            string books = Console.ReadLine();

            while (books != AniBook)
            {
                count++;
                if(countBook - count == 0)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {countBook} books.");

                    return;
                }
                
                books = Console.ReadLine();
            }

                Console.WriteLine($"You checked {count} books and found it.");
            
        }
    }
}
