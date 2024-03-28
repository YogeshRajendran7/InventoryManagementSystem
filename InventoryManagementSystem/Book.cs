using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string isbn, string title, string author, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
