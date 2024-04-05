class Reception : Event
{
    private string RSVPemail;
    public Reception(string title, string description, string date, string time, Address address, string RSVPemail) : base(title, description, date, time, address)
    {
        this.RSVPemail = RSVPemail;
    }
    public string displayshort()
    {
        return "Reception\n" + base.shorter();
    }
    public string displayfull()
    {
        return base.displayStandard() + $"\nRSVP@: {RSVPemail}";
    }
}