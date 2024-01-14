using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("nme");

        // creating variables 
        //int mycount = 34;
        //string name = "Phil";
        //var green = "green";
        //var myothercount = 3;
        // writing 
        //Console.Write($"a name: {green}");
        //Console.WriteLine(name);
        // read line user input 
        System.Console.WriteLine("what is your grade? ");
        var gradestring = Console.ReadLine();
        
        // converting variables 
        var grade = int.Parse(gradestring);
        // conditional
        var letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine("You Passed");
        }
        Console.WriteLine($"Your grade is {letter}");
    }
}
