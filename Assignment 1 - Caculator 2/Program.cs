﻿using System;

namespace Assignment_1___Caculator_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's work on math!");

            bool keepLooping = true;
            do
            {
                Console.WriteLine("Please input the first number:");
                string str1 = Console.ReadLine();
                int num1 = Convert.ToInt32(str1);

                Console.WriteLine("Please input the second number;");
                string str2 = Console.ReadLine();
                int num2 = Convert.ToInt32(str2);

                Console.WriteLine("---selection---\nEnter 1 to run Addition.\nEnter 2 to run Subtraction.\nEnter 3 to run Multiplication,\nEnter 4 to run Division.");
                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "1":
                        Console.WriteLine("result is:" + (num1 + num2));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("result is:" + (num1 - num2));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("result is:" + (num1 * num2));
                        Console.ReadKey();
                        break;

                    case "4":

                        if (num1 == 0 || num2 == 0)
                        {
                            Console.WriteLine("Please input other number");
                        }
                        else
                        {
                            Console.WriteLine("result is:" + (num1 / num2));
                            Console.ReadKey();
                            break;
                        }
                    default:
                        Console.WriteLine("Not a supported math operator");
                        break;
                           

                }

            } while (keepLooping);
        }
    }
}
