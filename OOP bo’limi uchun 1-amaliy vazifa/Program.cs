using OOP_bo_limi_uchun_1_amaliy_vazifa.Models;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Book class yozing. Unda propertylar va private field lar bo’lishi kerak. Class kitobning nomi," +
    " muallifi, narxi kabi malumotlarini o’zida ifodalashi lozim.\r\nKitobning nomini constructor yordamida kiriting!" +
    "\r\nBook class dan object yarating va object orqali propertylar yordamida fieldlarning qiymatini o’zgartiring.\r\n" +
    "Yuqoridagi Book classiga qo’shimcha xususiyatlar qo’shing va ularni method lar yordamida bajaring.\r\n");
Console.ResetColor();


Console.WriteLine("\n\n");

var author = new Author()
{
    Firstname = "Azizbek",
    Lastname = "Qasimbekov",
    Sex = true,
    Age = 24
};


var book = new Book(100000, "C# ni qaytadan o'qiymiz")
{
    Name = "Metanit",
    Title = "C# OOP",
    PublicationDate = new DateOnly(2024, 03, 13),
    Gerne = Gerne.NonFiction,
    Author = author,
};


Console.ForegroundColor = ConsoleColor.Blue;

author.AuthorInfo();
Console.WriteLine("\n\n");

Console.ForegroundColor = ConsoleColor.Yellow;

book.BookInfo();
Console.ResetColor();
