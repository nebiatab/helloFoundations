using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
 
        Console.Write("Please choose a number for x: "); //prompting user for input
        string strx = Console.ReadLine(); //reading and storing the input from user
        int x = int.Parse(strx); //converting the string x to an integer

        int y = (int)(3*(x * x* x) - 5*(x*x) +6); //Here is the polynomial to be calculated

        Console.WriteLine("Here is the answer: " + y);
        Console.ReadLine(); //This keeps the console open


        }
    }

