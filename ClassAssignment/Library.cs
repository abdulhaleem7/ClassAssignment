using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    public class Libarary : Book
    {
        public const string Name = "Patience Library";
        public static List<Book> books = new List<Book>();


        public Libarary(string author, string title) : base(title, author)
        {

            Author = author;
            Title = title;
            ISBN = GetISBN();
        }
        public void AddBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Libarary b = new Libarary(author, title);
            string f = b.ISBN;
            books.Add(b);
            Console.WriteLine($"The book ISBN is {f}");

        }

        public static void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No book is not available");

            }
            else
            {
                foreach (var b in books)
                {
                    if (books.Contains(b))
                    {
                        Console.WriteLine($"The book name is {b.Title}  and the author is {b.Author}.The book ISBN is {b.ISBN} the book was relesed at{b.TimeReleased} ");
                    }
                }
            }
        }

        public void RemoveBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book ISBN: ");
            string isbn = Console.ReadLine();
            foreach (var b in books)
            {
                if (b.ISBN == isbn && b.Author == author)
                {
                    books.Remove(b);
                    break;
                }
            }
            Console.WriteLine("The book has been removed successfully");
        }
    }


    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime TimeReleased { get; set; }


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = GetISBN();
            TimeReleased = DateTime.UtcNow;

        }


        public string GetISBN()
        {
            Random random = new Random();
            string r = random.Next(123456789).ToString();
            return r;
        }
        //Question 21
        public class TestClass
        {
            public static void Test()
            {
               /* Libarary b = new Libarary("g", "h");
                b.AddBook();
                b.RemoveBook();
                Libarary.ListBooks();*/

            }
        }
    }
 }
