using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Client.Pages;
using BookStore.Shared;

namespace BookStore.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly BookStoreDbContext db;
        public OrdersController(BookStoreDbContext db)
        {
            this.db = db;
        }

        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] Shared.ShoppingBasket basket)
        {
            Order order = new Order();
            order.Customer = basket.Customer;
            order.Books = new List<Book>();
            foreach(int bookID in basket.Orders)
            {
                var book = db.Books.Single(p => p.Id == bookID);
                order.Books.Add(book);

            }
            db.Orders.Add(order);
            db.SaveChanges();
            return Created($"orders", order.Id);
        }
    }
}
