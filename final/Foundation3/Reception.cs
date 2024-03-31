class Reception : Event
{
    private string RSVPemail;
     Reception(string title, string description, string date, string time, Address address, string RSVPemail) : base(title, description, date, time, address)
    {
        this.RSVPemail = RSVPemail;
    }
       
}