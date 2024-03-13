namespace OOP_bo_limi_uchun_1_amaliy_vazifa.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public DateOnly PublicationDate { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public Gerne Gerne { get; set; }


    private double price;
    private string description;



    public Book()
    {
        
    }

    public Book(string name)
    {
        this.Name = name;
    }

    public Book(string name, string title, Gerne gerne, double price, string description)
    {
        Name = name;
        Title = title;
        Gerne = gerne;
        this.price = price;
        this.description = description;
    }

    public Book(double price, string description)
    {
        this.price = price;
        this.description = description;
    }


    public void BookInfo()
    {
        Console.WriteLine($"Author: {Author.Firstname} {Author.Lastname}");
        Console.WriteLine($"Book: {Name}");
        Console.WriteLine($"Genre: {Gerne}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Date release: {PublicationDate}");
    }
}
