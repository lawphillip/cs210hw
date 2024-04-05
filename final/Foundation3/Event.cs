class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public string displayStandard()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress:\n" + address.getaddress();
    }
    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }
    public string shorter()
    {
        return $"Title: {title}\nDate: {date}";
    }
}