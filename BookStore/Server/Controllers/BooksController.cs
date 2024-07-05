using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Shared;

namespace BookStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStoreDbContext db;

        //private static readonly List<Book> Books = new List<Book>
        //{
        //    new Book(1, "Pepperoni", 8.99M, Spiciness.Spicy), new Book(2, "Margarita", 7.99M, Spiciness.None), new Book(3, "Diabolo", 9.99M, Spiciness.Hot)
        //};

        public BooksController(BookStoreDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/books")]
        public IQueryable<Book> GetBooks() => this.db.Books;

        [HttpPost("/books")]
        public IActionResult InsertBook([FromBody] Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return Created($"books/{book.Id}", book);
        }
    }
}
