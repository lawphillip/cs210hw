using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.IO; 
class Program
{
    
    
    static int MainMenu()
    {
        
        
            Console.Write("Please select one of the following choices \n 1. Write\n 2. Display\n 3. Save\n 4. Load\n 5. Quit\n What would you like to do? ");

            int i = int.Parse(Console.ReadLine());
           
        return i;
        
    }


    static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }

    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        int i = 0;
        
        while(i != 5)
        {
            
         int j = MainMenu();
         
            i = j;
            switch(i)
            {
                case 1:
                journal.AddEntry();

                break;

                case 2:
                
                journal.DisplayEntry();
                break;

                case 3:
                var lines = journal.Export();
                WriteFile(lines);
                break;

                case 4:
                var text = ReadFile();
                journal = new Journal(text);

                break;
                case 5: 

                break;


                default:
                    Console.WriteLine("That is not an option");
                break;
                
        }

        
        } 
        
    }
  
}
