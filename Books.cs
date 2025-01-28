namespace prac19;
using System;

public partial class Books
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    public Books(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }
}