﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public ShoppingBasket Basket { get; } = new ShoppingBasket();
        public UI UI { get; set; } = new UI();
        public decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetBook(id)!.Price);
    }
}
