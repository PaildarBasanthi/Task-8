using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age =0;
            bool isValidAge = false;

            while (!isValidAge)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    isValidAge = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (a positive integer).");
                }
            }

            if (age < 0)
            {
                Console.WriteLine("Invalid input. Age cannot be negative.");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }
}
