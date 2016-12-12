using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File: Struct.cs
using System;

struct Person
{
    public string Name;
    public int Age;
}

class Test
{
    static void Main()
    {
        Person[] persons = new Person[2];

        persons[0].Name = "Steve";
        persons[0].Age = 31;

        persons[1].Name = "Lisa";
        persons[1].Age = 28;

        foreach (Person p in persons)
        {
            Console.WriteLine("{0} is {1} years old.", p.Name, p.Age);
        }
    }
}