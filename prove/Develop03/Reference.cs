using System.ComponentModel.DataAnnotations;

class Reference
{
    private string reference;
    public Reference(string reference)
    {
        this.reference = reference;
    }
   public string Displayrefference()
    {
        return reference;
    }
}
