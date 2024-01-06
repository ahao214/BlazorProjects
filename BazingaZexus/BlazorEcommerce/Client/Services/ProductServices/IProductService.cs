namespace BlazorEcommerce.Client.Services.ProductServices
{
    public interface IProductService
    {
        // 每当产品列表发生变化时,调用此事件
        event Action ProductsChanged;

        List<Product> Products { get; set; }

        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }

        /// <summary>
        /// 获取商品
        /// </summary>
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);

        Task SearchProducts(string searchText,int page);
        Task<List<string>> GetProductsSearchSuggestions(string searchText);


    }
}
