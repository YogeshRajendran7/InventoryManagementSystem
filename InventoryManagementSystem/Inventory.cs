using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Inventory
    {
        private List<Book> books = new List<Book>();

        public void AddBook(string isbn, string title, string author, double price)
        {
            Book book = new Book(isbn, title, author, price);
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void UpdateBook(string isbn)
        { 
           

        }

        public void ListBook()
        {

        }
    }
}
