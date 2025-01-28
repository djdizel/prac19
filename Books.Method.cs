namespace prac19;
using System;

public partial class Books
{
    public void Info()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Объем в листах: {Pages}");
    }
}
