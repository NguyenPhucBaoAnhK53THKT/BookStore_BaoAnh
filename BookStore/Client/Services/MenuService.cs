using BookStore.Shared;
using System.Net.Http.Json;

namespace BookStore.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async ValueTask<Menu> GetMenu()
        {
            var Books = await httpClient.GetFromJsonAsync<Book[]>("/Books");
            return new Menu { Books = Books!.ToList() };
        }
    }
}
