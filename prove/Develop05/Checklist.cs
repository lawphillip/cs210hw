using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Checklist : Goal
{
    private int completionreward;
    private int Goalcount;
    private int count;
    
    private bool iscomplete;
    public Checklist (string Goalname, string description, int reward, int completionreward, int Goalcount) : base(Goalname, description, reward)
    {
        this.Goalcount = Goalcount;
        this.completionreward = completionreward;
    }
    public override void Display()
    {
        if(iscomplete == true)
        Console.WriteLine($"[X] {Goalname} ({description}) -- Currently Completed {count}/{Goalcount}");
        else
        Console.WriteLine($"[ ] {Goalname} ({description}) -- Currently Completed {count}/{Goalcount}");
    }

    public override int Awardpoint()
    {
        count += 1; 
        if ( count == Goalcount)
        {
            iscomplete = true;
            Console.WriteLine($"Congradulations! You have earned {completionreward + reward} Points");
            return completionreward + reward; 
        }
        else
        {
            Console.WriteLine($"Congradulations! You have earned {reward} Points");
            return reward;
        }   
    }
    public Checklist(string values) : base(values.Split($"&&")[0])
    {
        var checklistValues = values.Split($"{SEP}{SEP}")[1].Split(SEP);
        iscomplete = bool.Parse(checklistValues[0]);
        completionreward = int.Parse(checklistValues[1]);
        Goalcount = int.Parse(checklistValues[2]);
        count = int.Parse(checklistValues[3]);
    }
    public override string export()
    {
        return base.export() + $"{SEP}{SEP}{iscomplete}{SEP}{completionreward}{SEP}{Goalcount}{SEP}{count}";
    }



}
    


