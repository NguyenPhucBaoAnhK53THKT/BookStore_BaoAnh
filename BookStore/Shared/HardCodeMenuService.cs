using BookStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Shared
{
    public class HardCodeMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu
            {
                Books = new List<Book>
                    {
                        //new Book(1, "Tam Cam", 45000, ImageBook.book),
                        //new Book(2, "Cho Toi Xin Mot Ve Di Tuoi Tho", 7.99M, ImageBook.book),
                        //new Book(3, "Mat Biec", 9.99M, ImageBook.book)
                    }
            });
    }
}
