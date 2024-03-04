class Breathing : Activity
{
    private DateTime startTime;
    
    public void Breath()
    {
        TimeSpan duration = base.getDuration();
        base.startingmessage("Breathing");
        Console.WriteLine("This activity will help you relax by walking you through breathin in and out slowly. Clear your mind and focus in your breathing.");
        Console.Clear();
        base.getready();
        startTime = DateTime.Now;
        while(DateTime.Now - startTime <  duration)
        {
            Console.Write("Breath in....1");

            Thread.Sleep(1000);

           Console.Write("\b \b"); // Erase the character
           Console.Write("2"); // Replace it with the character

           Thread.Sleep(1000);

           Console.Write("\b \b"); // Erase the character
           Console.Write("3"); // Replace it with the character

           Thread.Sleep(1000);

           Console.Write("\b \b"); // Erase the character
           Console.Write("4"); // Replace it with the character
            
            Thread.Sleep(1000);
           Console.Write("\b \b"); // Erase the character
           Console.Write("5"); // Replace it with the character
            
            Thread.Sleep(1000);
           Console.Write("\n \n"); // Erase the character
           Console.Write("Breath Out....1");

            Thread.Sleep(1000);

           Console.Write("\b \b"); // Erase the character
           Console.Write("2"); // Replace it with the character

           Thread.Sleep(1000);

           Console.Write("\b \b"); // Erase the character
           Console.Write("3"); // Replace it with the character

           Thread.Sleep(1000);

           Console.Write("\b \b"); // Erase the character
           Console.Write("4"); // Replace it with the character
            
            Thread.Sleep(1000);
           Console.Write("\b \b"); // Erase the character
           Console.Write("5"); // Replace it with the character
           Console.WriteLine();
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
