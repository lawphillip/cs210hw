class Simple : Goal
{
    private bool iscomplete;
    public Simple (string Goalname, string description, int reward) : base(Goalname, description, reward)
    {

    }

    public override void Display()
    {
        if (iscomplete == true)
        Console.WriteLine($"[X] {Goalname} ({description})");
        else
        base.Display();
    }
    public override int Awardpoint()
    {
        iscomplete = true;
        Console.WriteLine($"Congradulations! You have earned {reward} Points");
        return reward;
    }
    public override string export()
    {
        return base.export() + $"{SEP}{SEP}{iscomplete}";
    }

    public Simple(string values) : base(values.Split($"&&")[0])
    {
        var simpleValues = values.Split($"{SEP}{SEP}")[1].Split(SEP);
        iscomplete = bool.Parse(simpleValues[0]);
    }


}
