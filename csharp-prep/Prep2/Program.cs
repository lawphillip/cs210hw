using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("nme");

        // creating variables 
        int mycount = 34;
        string name = "Phil";
        var green = "green";
        var myothercount = 3;
        // writing 
        Console.Write($"a name: {green}");
        Console.WriteLine(name);
        // read line user input 
        System.Console.WriteLine("what is your age");
        var agestring = Console.ReadLine();
        // converting variables 
        var age = int.Parse(agestring);
        // conditional
        if (age < 18)
        {
            System.Console.WriteLine("you're a minor");
        }
        else
        {
            System.Console.WriteLine("you're old");
        }
        



    }
}
