using System;
using System.Text.RegularExpressions;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        // list 
        List<int> myints = new List<int>();
        var moreInt = new List<int>();
        //addingitems
        moreInt.Add(34);
        moreInt.Add(23);

        //foreach
        foreach(var n in moreInt)
        {
            Console.WriteLine($"N = {n}");
        }

        List<int> numberline = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        var number = 10000;
        do
        {
            Console.Write("Enter number ");
            number = int.Parse(Console.ReadLine());
            numberline.Add(number);
        }while (number != 0);
        double total = 0;
        foreach (int num in numberline)
        {
            total += num;
        }
        foreach(var n in numberline)
        {
            Console.WriteLine($"N = {n}");
        }
        Console.WriteLine($"the sum is: {total}");
        double average = total / (numberline.Count -1);
        Console.WriteLine($"The average is {average}");
        int max = numberline.Max();
        Console.WriteLine($"The Largest number is {max}");
    }
}