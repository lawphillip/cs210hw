public class Journal
{
    public List<Entry> entries;

        public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string[] importLines)
    {
        entries = new List<Entry>();
        foreach (var line in importLines)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    public void DisplayEntry()
    {
        Console.WriteLine("\n Journal entries:");
        Console.WriteLine("---------");

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }

        
    }

    
    public string getprompt()
    {
    var Prompts = new List<string>();
    Prompts.Add("What was a challenge you faced today?");
    Prompts.Add("What accomplishment are you proud of today?");
    Prompts.Add("What fear did you face today?");
    Prompts.Add("What did you prioritize your time in today?");
    Prompts.Add("What is something unexpected that happened today?");
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(0, 5);
    var prompt = Prompts[number];
    return(prompt);
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }

    public void AddEntry()
    {
        string prom = getprompt();
        Console.WriteLine(prom);

        Console.Write("Enter your Journal entry:");
        var text = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        

        var entry = new Entry(text,prom,date);

        entries.Add(entry);
    }

   
}
