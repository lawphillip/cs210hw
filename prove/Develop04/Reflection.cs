class Reflection : Activity
{
private DateTime startTime;
private List<string> reflectionprompts = new List<string> {"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless"};
private List<string> thoughtprompts = new List<string>{"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"};
Random random = new Random();

    
public void reflect()
{
    int i = 1000;
    int randomNumber = random.Next(0,3);
    TimeSpan duration = base.getDuration();
    base.startingmessage("Reflection");
    Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. this will help you recognise the power you have and how you can use it in other aspects of your life.");
    //Console.Clear();
    Console.WriteLine("Consider the following Prompt:\n");
    Console.WriteLine($"---{reflectionprompts[randomNumber]}----");
    Console.WriteLine("When you have something in mind, enter when ready");
    Console.ReadLine();
    Console.WriteLine("Now ponder on each of the following questions as they related to this experience\n You may begin in : ");
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
            int rand = random.Next(0,8);
            if(rand != i){
            Console.WriteLine($"{thoughtprompts[random.Next(0,8)]}");
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
            Console.WriteLine();
            }
            i = rand;
        }
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
