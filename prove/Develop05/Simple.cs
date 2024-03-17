class Simple : Goal
{
    private bool iscomplete;
    public Simple (string Goalname, string description, int reward) : base(Goalname, description, reward)
    {

    }

    public override void Display()
    {
        if (iscomplete == true)
        Console.WriteLine($"[X] {Goalname} {description}");
        else
        base.Display();
    }
    public override int Awardpoint()
    {
        iscomplete = true;
        return reward;
    }
    public override string export()
    {
        return base.export() + $"{SEP}{iscomplete}";
    }


}
