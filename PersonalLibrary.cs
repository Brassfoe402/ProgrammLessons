using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, string publisher, int year)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title}, Автор: {Author}, Издатель: {Publisher}, Год издания: {Year} ";
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(string title, string author, string publisher, int year)
    {
        books.Add(new Book(title, author, publisher, year));
    }

    public bool RemoveBook(string title)
    {
        Book bookToRemove = FindBook(title);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            return true;
        }
        return false;
    }

    public Book FindBook(string title)
    {
        foreach (Book book in books)
        {
            if (book.Title == title)
            {
                return book;
            }
        }
        return null;
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        List<Book> matches = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Author == author)
            {
                matches.Add(book);
            }
        }
        return matches;
    }

    public List<Book> FindBooksByPublisher(string publisher)
    {
        List<Book> matches = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Publisher == publisher)
            {
                matches.Add(book);
            }
        }
        return matches;
    }

    public void PrintLibrary()
    {
        Console.WriteLine("--- Библиотека ---");
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Найти книгу по названию");
            Console.WriteLine("4. Найти книгу по автору");
            Console.WriteLine("5. Найти книгу по издательству");
            Console.WriteLine("6. Показать все книги");
            Console.WriteLine("7. Выход");

            string input = Console.ReadLine();
            int choice = int.Parse(input);

            switch (choice)
            {
                case 1:
                    Console.Write("Название: ");
                    string title = Console.ReadLine();
                    Console.Write("Автор: ");
                    string author = Console.ReadLine();
                    Console.Write("Издатель: ");
                    string publisher = Console.ReadLine();
                    Console.Write("Год издания: ");
                    int year = int.Parse(Console.ReadLine());
                    library.AddBook(title, author, publisher, year);
                    break;
                case 2:
                    Console.Write("Название: ");
                    string titleToRemove = Console.ReadLine();
                    bool removed = library.RemoveBook(titleToRemove);
                    if (removed)
                    {
                        Console.WriteLine("Книга удалена.");
                    }
                    else
                    {
                        Console.WriteLine("Такой книги нет в библиотеке.");
                    }
                    break;
                case 3:
                    Console.Write("Название: ");
                    string titleToFind = Console.ReadLine();
                    Book book = library.FindBook(titleToFind);
                    if (book != null) 
                    {
                        Console.WriteLine("Такая книга есть в библиотеке");
                        Console.WriteLine(book);
                    }
                    else
                    {
                        Console.WriteLine("Такой книги нет в библиотеке");
                    }
                    break;
                case 4:
                    Console.Write("Автор: ");
                    string authorToFind = Console.ReadLine();
                    List<Book> booksByAuthor = library.FindBooksByAuthor(authorToFind);
                    if (booksByAuthor.Count > 0)
                    {
                        Console.WriteLine("Книги этого автора: ");
                        foreach (Book b in booksByAuthor) 
                        { 
                            Console.WriteLine(b);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Книг этого автора нет в библиотеке");
                    }
                    break;
                    case 5:
                    Console.Write("Издатель: ");
                    string publisherToFind = Console.ReadLine();
                    List<Book> booksByPublisher = library.FindBooksByPublisher(publisherToFind);
                    if (booksByPublisher.Count > 0)
                    {
                        Console.WriteLine($"Книги опубликованные издателем {publisherToFind}:");
                        foreach (Book b in booksByPublisher)
                        {
                            Console.WriteLine(b);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Нет книг, опубликованных издателем {publisherToFind}.");
                    }
                    break;
                case 6:
                    library.PrintLibrary();
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
            Console.WriteLine();
        }
    }
}

