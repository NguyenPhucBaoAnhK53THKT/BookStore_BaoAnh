using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookStore.Shared
{
    public class Book
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public ImageBook imagebook { get; }

        public Book(int id, string name, decimal price, ImageBook imagebook)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.imagebook = imagebook;
        }
        [JsonIgnore]
        public ICollection<Order>? Orders  { get; set; }
    }
}
