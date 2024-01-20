using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        // while loop 
        //int count = 5;
        //while (count < 10)
        //{
        //Console.WriteLine($"count = {count}");
        //count += 1;
        //}
        // do while 
        //var anotherc = 2;
        //do {
            //Console.WriteLine($"another count = {anotherc++}");
        //} while(anotherc < 10);

        //for loop 
       //for (var i =0; i < 5; i++)
        //{
            //Console.WriteLine($"i = {i}");
        //}
        // list 
        //List<int> myints = new List<int>();
        //var moreInt = new List<int>();
        //moreInt.Add(34);
        //moreInt.Add(23);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        var guess = 0;
        Console.WriteLine("Guess what the magic number is ");
        guess = int.Parse(Console.ReadLine());
        while (guess != number)
         {
            
            Console.WriteLine("Guess what the magic number is ");
            int input = int.Parse(Console.ReadLine());
            guess = input;
            if (guess > number)
            {
                Console.WriteLine("Higher");
            }
            else if( guess < number)
            {
                Console.WriteLine("Lower");
            }
         }
        } 



    }
