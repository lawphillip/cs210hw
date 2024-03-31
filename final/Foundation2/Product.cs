using System.Security;
using System.Security.Cryptography;

class Product
{
    private string name;
    private string productId;
    private double unitprice;
    private int quantity;

    public Product(string name, string productId, double unitprice, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.unitprice = unitprice;
        this.quantity = quantity;
    }
    public string getproname()
    {
        return name;
    }
    public string getproId()
    {
        return productId;
    }
    
    public double productCost()
    {
        return quantity * unitprice;
    }
}