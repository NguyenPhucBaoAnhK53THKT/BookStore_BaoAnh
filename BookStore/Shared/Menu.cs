using BookStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Shared
{
    public class Menu
    {
        public List<Book> Books { get; set; } =  new List<Book>();
        public void addBook(Book book)
        {
            Books.Add(book);
        }
        public Book? GetBook(int id) => (Books.SingleOrDefault(book => book.Id == id));
            
        
    }
}
