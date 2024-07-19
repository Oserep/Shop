using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestAPP.Models;

namespace TestAPP
{
    public class ApiClient
    {
        private readonly HttpClient _client;

        public ApiClient(string baseAddress)
        {
            _client = new HttpClient { BaseAddress = new Uri(baseAddress) };
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var response = await _client.GetAsync("api/products");
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<Product>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var response = await _client.GetAsync($"api/products/{id}");
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Product>(await response.Content.ReadAsStringAsync());
        }

        public async Task CreateProductAsync(Product product)
        {
            var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/products", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProductAsync(Product product)
        {
            var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"api/products/{product.IdProduct}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProductAsync(int id)
        {
            var response = await _client.DeleteAsync($"api/products/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
