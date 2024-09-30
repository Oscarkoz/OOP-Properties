using System;

namespace OOP Properties

class King
{
    // Property Title med getter och setter
    public string Title { get; set; }

    // Konstruktor som sätter Title via en parameter
    public King(string title)
    {
        Title = title;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Skapar två kungar, Charles och Richard
        King charles = new King("Charles");
        King richard = new King("Richard");

        // Skriver ut deras titlar till konsolen
        Console.WriteLine($"King 1: {charles.Title}");
        Console.WriteLine($"King 2: {richard.Title}");
    }
}
