class Outdoor : Event
{
    private string weather;
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        this.weather = weather;
    }
    public string displayshort()
    {
        return "Outdoor\n" + base.shorter();
    }
    public string displayfull()
    {
        return base.displayStandard() + $"\nThe forcasted weather is: {weather}";
    }
}