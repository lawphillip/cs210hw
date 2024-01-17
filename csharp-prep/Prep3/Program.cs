using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        // while loop 
        int count = 5;
        while (count < 10)
        {
        Console.WriteLine($"count = {count}");
        count += 1;
        }
        // do while 
        var anotherc = 2;
        do {
            Console.WriteLine($"another count = {anotherc++}");
        } while(anotherc < 10);

        //for loop 
        for (var i =0; i < 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }
        // list 
        List<int> myints = new List<int>();
        var moreInt = new List<int>();
        moreInt.Add(34);
        moreInt.Add(23);

        int guess = int.Parse(Console.ReadLine());
    }
}