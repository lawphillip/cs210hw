using System.Dynamic;

class Comment
{
    private string name;
    private string commenttext;

    public Comment(string name, string commenttext)
    {
        this.name = name;
        this.commenttext = commenttext;
    }

    public string getname()
    {
        return name;
    }
    public string getcomment()
    {
        return commenttext;
    }
}
