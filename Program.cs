using System;

namespace Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");
            try
            {
                string input = Console.ReadLine();
                int yrs_of_exp = int.Parse(input);
                for (int i = 1; i <= yrs_of_exp; i++)
                {
                    Console.WriteLine("You have got " + i.ToString() + " years of experience");
                }
                    Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
