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
    }
}
