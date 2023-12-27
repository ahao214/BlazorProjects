namespace BlazorEcommerce.Server.Services.ProductServices
{
    public interface IProductService
    {
        /// <summary>
        /// 获取产品数据
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

    }
}
