using System;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int YearPublished { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, string publisher, int yearPublished, int pages, double price, bool isAvailable)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            YearPublished = yearPublished;
            Pages = pages;
            Price = price;
            IsAvailable = isAvailable;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine("Назва: " + Title);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Видавництво: " + Publisher);
            Console.WriteLine("Рік публікації: " + YearPublished);
            Console.WriteLine("Кількість сторінок: " + Pages);
            Console.WriteLine("Ціна: $" + Price);
            Console.WriteLine("Доступна: " + (IsAvailable ? "так" : "ні"));
        }
    }

    public class ExtendedBook : Book
    {
        public string Genre { get; set; }

        public ExtendedBook(string title, string author, string publisher, int yearPublished, int pages, double price, bool isAvailable, string genre)
            : base(title, author, publisher, yearPublished, pages, price, isAvailable)
        {
            Genre = genre;
        }
    }
}
