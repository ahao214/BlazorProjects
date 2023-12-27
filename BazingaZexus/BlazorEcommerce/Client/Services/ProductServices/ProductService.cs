using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action ProductsChanged;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        
        /// <summary>
        /// 获取商品
        /// </summary>
        /// <param name="categoryUrl"></param>
        /// <returns></returns>
        public async Task GetProducts(string? categoryUrl=null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("/api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"/api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }

        public Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }
    }
}
