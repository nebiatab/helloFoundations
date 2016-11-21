using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Hw #4 : Looping and Arrays
// Write a program that allows the user to enter the number of factorials to display.

class LoopingandArrays
    {
        static void Main()
        {
                // Ask the user for a number
                Console.Write("Please enter a number: ");

                // Save that number (x) and convert it from a string to an integer type
                string strx = Console.ReadLine();
                int x = int.Parse(strx);
                int factorial = 1;

                // Feed that number (x) into a for loop that will calculate the factorial from 1 to x
                // Factorial of each number leading up to x is displayed on the console
                for (int z = 1; z <= x; z++)
                    {
                        factorial = factorial * z;
                        Console.WriteLine("{0}! = {1}", z, factorial);        
                    }

                Console.ReadLine();

        }
    }
