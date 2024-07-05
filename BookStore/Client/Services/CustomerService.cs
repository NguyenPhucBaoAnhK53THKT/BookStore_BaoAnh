using BookStore.Shared;
using System.Net.Http.Json;

namespace BookStore.Client.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient httpClient;
        public CustomerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Customer[]> GetAllCustomer()
        {
            return await httpClient.GetFromJsonAsync<Customer[]>("/customers");

        }
    }
}
