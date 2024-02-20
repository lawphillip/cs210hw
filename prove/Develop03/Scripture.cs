using System;
// moroni 10 4-5
class Program
{
    static void Main(string[] args)
    {
        string thereff = "Moroni 10:3-4";
        Scripture scripture = new Scripture();
        var counter = 0;
        scripture.AddWords();
        var theref = new Reference(thereff);
        scripture.DisplayScripture(theref);
        while(true)
        {
            
            var userinput = "";
            Console.WriteLine("Press enter to hide words or exit to exit program");
            userinput = Console.ReadLine();
            Console.Clear();
            scripture.Hidewords();
            scripture.Hidewords();

            scripture.DisplayScripture(theref);
            if (counter == 61)
            break;
            else if (userinput == "exit")
            break;
            counter ++;

        }
    }
}
