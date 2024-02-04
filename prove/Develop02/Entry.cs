public class Entry
{
    public string getprompt()
    {
        var Prompts = new List<string>();
        Prompts.Add("What was a challenge you faced today?");
        Prompts.Add("What accomplishment are you proud of today?");
        Prompts.Add("What fear did you face toady?");
        Prompts.Add("What did you prioritize your time in today?");
        Prompts.Add("What is something unexpected that happened today?");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 5);
        var prompt = Prompts[number];
        return(prompt);
    }
 public string entry;
    public string prompt;

    public string date;


    public Entry(string entry, string prompt, string date)
    {
        this.entry = entry;
        this.prompt = prompt;
        this.date = date;
    }

    public Entry(string import)
    {
        var parts = import.Split("|");//prompt|entry|date
        this.date = parts[0];
        this.prompt = parts[1];
        this.entry = parts[2];
    }

    public string Export()
    {
        return $"{date}|{prompt}|{entry}";
    }

    public string DisplayString()
    {
        return $"{date}\n{prompt}\n{entry}";
    }
    
}
