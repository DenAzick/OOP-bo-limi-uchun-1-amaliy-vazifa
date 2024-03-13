using System.Xml.Linq;

namespace OOP_bo_limi_uchun_1_amaliy_vazifa.Models;

public class Author : User
{
    public List<Book> Books { get; set; }

    public void AuthorInfo()
    {
        Console.WriteLine($"Author: {Firstname} {Lastname}");
        Console.WriteLine($"Sex: {Sex}");
        Console.WriteLine($"Age: {Age}");
    }

}
