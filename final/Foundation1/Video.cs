using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Video
{
    List<Comment> comments = new List<Comment>();

    private string title;
    private string author;
    private int length;
    private int commentcount;
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }
    public void makecomment(string name, string comment)
    {
        comments.Add(new Comment(name, comment));
        commentcount++;
    }

    private void displaycomments()
    {
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"Name:{comment.getname()}");
            Console.WriteLine($"Comment:{comment.getcomment()}");
        }
    }

    public void displayvideo()
    {
        Console.WriteLine($"Video title: {title}");
        Console.WriteLine($"Video author: {author}");
        Console.WriteLine($"Video Length: {length}");
        Console.WriteLine($"Number of comments made: {commentcount}");
        Console.WriteLine("Comments");
        displaycomments();
    }
    
    
}