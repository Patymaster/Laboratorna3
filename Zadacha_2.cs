using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Book
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть назву книги: ");
            Title t = new Title();
            t.title = Console.ReadLine();

            Console.WriteLine("Введiть автора: ");
            Author a = new Author();
            a.author = Console.ReadLine();

            Console.WriteLine("Введiть контент: ");
            Content c = new Content();
            c.content = Console.ReadLine();
            t.Show();
            a.Show();
            c.Show();
        }
    }
    class Title
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
    class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
    class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
