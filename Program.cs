using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRANZ_AEDAM_JOSHUA_C_JAVIER
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
                while (true)
                {
                    Console.WriteLine("\n--- Simple Calculator ---");
                    Console.WriteLine("1. ADD\n2. SUBTRACT\n3. EXIT");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();

                    if (choice == "3")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }

                    if (choice != "1" && choice != "2")
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                        continue;
                    }

                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = choice == "1" ? num1 + num2 : num1 - num2;
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
    }
   
