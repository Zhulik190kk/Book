using System;
using BookLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість книг: ");
            int n = int.Parse(Console.ReadLine());

            ExtendedBook[] books = new ExtendedBook[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введіть дані для книги {i + 1}:");
                Console.Write("Назва: ");
                string title = Console.ReadLine();
                Console.Write("Автор: ");
                string author = Console.ReadLine();
                Console.Write("Видавництво: ");
                string publisher = Console.ReadLine();
                Console.Write("Рік публікації: ");
                int yearPublished = int.Parse(Console.ReadLine());
                Console.Write("Кількість сторінок: ");
                int pages = int.Parse(Console.ReadLine());
                Console.Write("Ціна(у $): ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Доступна? (так/ні): ");
                bool isAvailable = Console.ReadLine().ToLower() == "так";
                Console.Write("Жанр: ");
                string genre = Console.ReadLine();

                books[i] = new ExtendedBook(title, author, publisher, yearPublished, pages, price, isAvailable, genre);
            }

            Console.WriteLine("\nІнформація про книги:");
            foreach (var book in books)
            {
                Console.WriteLine();
                book.PrintBookInfo();
            }
        }
    }
}
