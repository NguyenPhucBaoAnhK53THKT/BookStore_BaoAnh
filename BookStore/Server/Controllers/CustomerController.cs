using BookStore.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly BookStoreDbContext db;
        public CustomerController(BookStoreDbContext db)
        {
            this.db = db;
        }

        [HttpGet("/customers")]
        public IQueryable<Customer> GetBooks() => this.db.Customers;
    }
}
