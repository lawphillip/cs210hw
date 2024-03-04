using System.Reflection.Metadata;

class Listing : Activity
{
private DateTime startTime;
private int count = 0;
private List<string> listprompts = new List<string>{"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"};
Random random = new Random();
public void list()
{
    int randomNumber = random.Next(0,4);
    base.startingmessage("Reflection");
    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can\n");
    Console.Clear();
    TimeSpan duration = base.getDuration();
    base.getready();
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine($"---{listprompts[randomNumber]}----");
    Console.WriteLine("You may begin in : ");
    Console.Write("5");

    Thread.Sleep(500);

    Console.Write("\b \b"); // Erase the character
    Console.Write("4"); // Replace it with the character

    Thread.Sleep(500);

    Console.Write("\b \b"); // Erase the character
    Console.Write("3"); // Replace it with the character

    Thread.Sleep(500);

    Console.Write("\b \b"); // Erase the character
    Console.Write("2"); // Replace it with the character
            
    Thread.Sleep(500);
    Console.Write("\b \b"); // Erase the character
    Console.Write("1");
    Thread.Sleep(500);
    Console.Write("\b \b");
    Console.Clear();
    startTime = DateTime.Now;
     while(DateTime.Now - startTime <  duration)
        {
            Console.Write(">");
            Console.ReadLine();
            count ++;
        }
    Console.WriteLine($"You listed {count} items ");
    Console.WriteLine();
 Console.WriteLine("Well Done!");
                    Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the character
            Console.Write("/"); // Replace it with the character

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the character
            Console.Write("-"); // Replace it with the character

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the character
            Console.Write("\\"); // Replace it with the character
            
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the character
        base.endingMessage();
        Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the character
            Console.Write("/"); // Replace it with the character

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the character
            Console.Write("-"); // Replace it with the character

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the character
            Console.Write("\\"); // Replace it with the character
            
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the character
}
}
