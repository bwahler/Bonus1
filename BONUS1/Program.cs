using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool execute = true;
            while (execute == true)
            {
                //greet the user
                Console.WriteLine("Welcome to the Letter Grade Converter!");
                try
                {
                    //Prompt user for numerical grade
                    Console.WriteLine("Please enter a numerical grad 0 to 100:");
                    int grade = int.Parse(Console.ReadLine());

                    if (grade <= 100 && grade >= 88)
                    {
                        Console.WriteLine("A");
                    }
                    else if (grade <= 87 && grade >= 80)
                    {
                        Console.WriteLine("B");
                    }
                    else if (grade <= 79 && grade >= 67)
                    {
                        Console.WriteLine("C");
                    }
                    else if (grade <= 66 && grade >= 60)
                    {
                        Console.WriteLine("D");
                    }
                    else if (grade <= 59 && grade >= 0)
                    {
                        Console.WriteLine("F");
                    }
                    execute = Continue();
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                }
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to continue? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool loop;

            if (userContinue == "y")
            {
                loop = true;
            }
            else if (userContinue == "n")
            {
                loop = false;
            }
            else
            {
                Console.WriteLine("That is not a valid input");
                loop = Continue();
            }
            return loop;
        }
    }
}
