using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            Book hello = new Book() {
                Title = "Hello",
                Author = "John",
                ISBN = "1234"
            };
            Book goodbye = new Book(); 
                goodbye.Title = "Goodbye";
                goodbye.Author = "Paul";
                goodbye.ISBN = "5678";

            Book stop = new Book() {
                Title = "Stop",
                Author = "George",
                ISBN = "abcd"
            };
            Book goGoGo = new Book();
                goGoGo.Title = "GoGoGo";
                goGoGo.Author = "Ringo";
                goGoGo.ISBN = "efgh";

            Book high = new Book();
                high.Title = "High";
                high.Author = "Rocky Raccoon";
                high.ISBN = "ijkl";

            Book low = new Book() {
                Title = "Low",
                Author = "Mean Mr. Mustard",
                ISBN = "mnop"
            };

            List<Book> initialBooks = new List<Book>() {
                high, low
            };

            Library helloGoodbye = new Library (initialBooks, "Vol 1", "Abbey Road");

            helloGoodbye.AddToInventory(hello);
            helloGoodbye.AddToInventory(goodbye);
            helloGoodbye.AddToInventory(stop);
            helloGoodbye.AddToInventory(goGoGo);

            if (helloGoodbye.IsAvailable("mnop"))
            {
                Console.WriteLine($"{low.Title} is availabe");
            }
            else 
            {
                Console.WriteLine($"{low.Title} is not available");
            }

        }
    }
}
