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
        Console.WriteLine($"[X] {Goalname} {description} -- Currently Completed {count}/{Goalcount}");
        else
        Console.WriteLine($"[ ] {Goalname} {description} -- Currently Completed {count}/{Goalcount}");
    }

    public override int Awardpoint()
    {
        count += 1; 
        if ( count == Goalcount)
        {
            iscomplete = true;
            return completionreward + reward; 
        }
        else
            return reward;   
    }

    public override string export()
    {
        return base.export() + $"{SEP}{iscomplete}{SEP}{completionreward}{SEP}{Goalcount}{SEP}{count}";
    }

    

}
