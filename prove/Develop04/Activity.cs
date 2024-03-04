class Activity
{
    private TimeSpan time;
    private string input;
    private string activityName;

    // public Activity(int duration)
    // {
    //     this.duration = duration;
    // }
    protected TimeSpan getDuration()
    {
        
        Console.WriteLine("Please enter the time in seconds you want to do this activity");
        input = Console.ReadLine();
        string timefix = $"00:00:{input}";
         if (TimeSpan.TryParse(timefix, out TimeSpan duration))
        {
          time = duration;
        }
        else
        {
        Console.WriteLine("Invalid input. Please enter a valid duration (e.g., 1h30m).");
        }
        return time;
    }
    public void startingmessage(string activityName)
    {
        this.activityName = activityName;
        Console.WriteLine($"Welcome to the {activityName} Activity");
    }

    protected void getready()
    {
        Console.WriteLine("Get Ready...\n");
        for(int i = 0; i < 3; i++)
        {   
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
    public void endingMessage()
    {
        Console.WriteLine($"You have completed another {input} seconds of the {activityName} Activity");
    }

}
