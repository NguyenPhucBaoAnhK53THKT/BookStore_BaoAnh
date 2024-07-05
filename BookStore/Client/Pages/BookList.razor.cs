using Microsoft.AspNetCore.Components;
using BookStore.Shared;
namespace BookStore.Client.Pages
{
    public partial class BookList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Book> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Book> Selected { get; set; } = default!;
    }
}
