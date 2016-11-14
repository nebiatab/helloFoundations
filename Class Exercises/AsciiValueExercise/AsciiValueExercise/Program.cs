using System;

    class AsciiValue
    {
        static void Main()
        {
        Console.Write("Fine Ascii value for: ");  //  ask user for number
        string strx = Console.ReadLine();        // read and store input
        char c = strx[0];        // only take first character of input
        int asciiValue = (int)c;                         // convert to Ascii value

        // show user value in console
        Console.WriteLine("Ascii ={0}", asciiValue);




        Console.ReadLine();
        }
    }
