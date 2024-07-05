using Microsoft.AspNetCore.Components;
using BookStore.Shared;

namespace BookStore.Client.Pages
{
    partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Book> GetBookFromId { get; set; } = default!;
        private IEnumerable<(Book Book, int pos)> Books { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Books = Orders.Select((id, pos) => (Book: GetBookFromId(id), pos: pos));
            TotalPrice = Books.Select(tuple => tuple.Book.Price).Sum();
        }
    }
}
