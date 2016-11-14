using System;

//HW #3 Control and Looping Statements
//Write a program that calculates the factorial of an integer n given by the user. Please enter a small integer.


    class ControlStatements
    {
        static void Main()
        {
       
        Console.Write("Calculating factorials! Please choose a non-negative value for n: ");  // step 1: prompt the user for an integer n

        string strn = Console.ReadLine(); // step 2: store that input and convert to integer type
        int n = int.Parse(strn);

        /* int factn = 1;
         for (n = 1; n >= 1; n--)       // step 3: create loop that will calculate n! -- n*(n-1)?
         {
             factn = (n * (n - 1));

         }*/

        int factorial = 0;
        if (n >= 1)
        {
            factorial = (n * (n - 1));
            factorial = n * factorial;
            n--;
        }

        
        Console.WriteLine("Factorial equals: " + factorial);    // step 5: send result to console

        Console.ReadLine();      // step 6: Keep console open

        
    }
}
