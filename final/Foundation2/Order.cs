using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection.Emit;

class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;
    public Order(Customer customer)
    {
        this.customer = customer;
    }
    public double totalcost()
    {
        double total = 0;
        foreach(Product product in products)
        {
            total += product.productCost();
        }
        if(customer.national())
        total += 5;
        else
        total += 35;
        return Math.Round(total,2,MidpointRounding.AwayFromZero);
    }
    public void addproduct(string name, string productId, double unitprice, int quantity)
    {
        products.Add(new Product(name, productId, unitprice, quantity));
    }
    public string getpackinglabel()
    {
        string label = "";
        foreach(Product product in products)
        {
            label += product.getproname() + " : " + product.getproId() + "\n";
        }
        return label;
    }
     
    public string getshippinglabel()
    {
        string label = customer.getname() + "\n" + customer.getaddress();
        return label;
    }
}