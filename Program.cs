namespace prac19;
using System;
class Program
{
    static void Main(string[] args)
    {
        Books myBook = new Books("Война и мир", "Лев Толстой", 1869, 1225);
        
        myBook.Info();
    }
}