class Lecture : Event
{
    private string speaker;
    private int capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }
    public string displayfull()
    {
        return base.displayStandard() + $"\nThe Speaker is: {speaker}\n Max capacity is: {capacity}";
    }
    public string displayshort()
    {
        return "Lecture\n" + base.shorter();
    }


}