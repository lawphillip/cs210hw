using System.Runtime.CompilerServices;

class Customer
{
    private string name;
    private Address address;
    private bool isInUS;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
        isInUS = address.InUSA();
    }
    public bool national()
    {
    return isInUS;
    }
    public string getname()
    {
        return name;
    }
    public string getaddress()
    {
        return address.getaddress();
    }


}