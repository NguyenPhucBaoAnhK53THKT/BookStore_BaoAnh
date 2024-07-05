using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Shared
{
    public class ConsoleOrderService : IOrderService
    {
        public ValueTask PlaceOrder(ShoppingBasket basket)
        {
            Console.WriteLine($"Placing order for {basket.Customer.Name}");
            return new ValueTask();
        }        
    }
}
