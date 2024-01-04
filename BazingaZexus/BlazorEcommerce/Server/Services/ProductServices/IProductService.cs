namespace BlazorEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        /// <summary>
        /// 获取产品数据
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        /// <summary>
        /// 获取产品详情
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<ServiceResponse<Product>> GetProductAsync(int productId);

        /// <summary>
        /// 根据分类获取产品数据
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        /// <summary>
        /// 根据内容搜索商品
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);

        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);

        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
    }
}
