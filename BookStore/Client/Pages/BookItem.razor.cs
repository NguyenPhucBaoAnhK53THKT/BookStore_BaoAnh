using Microsoft.AspNetCore.Components;
using BookStore.Shared;
namespace BookStore.Client.Pages
{
    public partial class BookItem
    {
        [Parameter]
        public Book Book { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]

        public EventCallback<Book> Selected   { get; set; } = default!;

        private string BookImage(ImageBook image) => $"images/{image.ToString().ToLower()}.png";
    }
}
