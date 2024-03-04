using System;

class Program
{   
    static void Main(string[] args)
    {
        Breathing bactivity = new Breathing();
        Reflection ractivity = new Reflection();
        Listing lactivity = new Listing();
        var menu = 0;
        while(menu != 4)

        {
            //Console.Clear();
            Console.WriteLine("Menu Options:\n1. Breathing Activity\n 2. Reflection Activity\n 3. Listing Activity\n 4. Quit\n");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                bactivity.Breath();
                break;
                case 2:
                ractivity.reflect();

                break;

                case 3:
                lactivity.list();
                break;

                case 4:

                break;

                default:
                Console.WriteLine("That is not an option");
                break;
            }

        }

        
        

    }
}
