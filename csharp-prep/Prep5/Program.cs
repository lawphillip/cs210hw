using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //functions 
        //returntype funtionname(parameter 1)
        int add2(int number)
        {
            return number +2;
        }
        int more = add2(10);

        // void function no return
        void PrintName(string name)
        {
            if(name.Length == 0)
            {
                return;
            }
            Console.WriteLine($"name is {name}");
            return;
        }
        var MyName = "BOB";
        PrintName(MyName);

        //variable scope 
        var y = 0;
        {
            var w = 10;
            w = y + 4;
            y = w + 5;
        }
        // y = w + 4; not in the scope 

        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
            return;
        }
        string PromptUserName()
        {
            string UserName = "";
            Console.Write("Please enter your name: ");
            UserName = Console.ReadLine();
            return UserName;

        }
        int PromptUserNumber()
        {
            int FavNumber = 0; 
            Console.Write("Please enter your favorite number: ");
            FavNumber = int.Parse(Console.ReadLine());

            return FavNumber;
        }
        int SquareNumber(int number)
        {
            number = number * number;
            return number;
        }
        void DisplayResult(string Name, int NumberSquared) 
        {
            Console.WriteLine($"{Name}, the square of your number is {NumberSquared}");
        }
        DisplayWelcome();
        string Yourname;
        int FavoriteNumber;
        Yourname = PromptUserName();
        FavoriteNumber = PromptUserNumber();
        int numbertimesnumber;
        numbertimesnumber = SquareNumber(FavoriteNumber);
        DisplayResult(Yourname,numbertimesnumber);


    }
}