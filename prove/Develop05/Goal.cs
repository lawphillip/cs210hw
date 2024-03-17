using System.Runtime.InteropServices;
using System.Security;

class Goal
{
    protected string Goalname;
    protected string description;
    protected int reward;
    
    public string SEP = "&";

    public void import()
    {
        
    }
    public Goal(string Goalname, string description, int reward)
    {
        this.Goalname = Goalname;
        this.description = description;
        this.reward = reward;
    }
    
    public virtual string export()
    {
        return $"{Goalname}{SEP}{description}{SEP}{reward}";
    }

    public virtual void Display()
    {
        Console.WriteLine($"[ ] {Goalname} {description}");
    }
    public virtual int Awardpoint()
    {
        return reward;
    }
}
