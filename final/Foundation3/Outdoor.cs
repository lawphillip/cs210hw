class Outdoor : Event
{
    private string weather;
     Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        this.weather = weather;
    }
       
}