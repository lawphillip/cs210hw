class Address
{
    private string streetaddress;
    private string city;
    private string state;
    private string country;
    public Address(string streetaddress, string city, string state, string country)
    {
        this.streetaddress = streetaddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    public string getaddress()
    {
        return $"{streetaddress}\n{city}, {state}\n{country}";
    }

}