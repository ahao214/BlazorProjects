namespace BlazorEcommerce.Server.Services.CategoryServices
{
    /// <summary>
    /// 商品分类接口
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// 获取所有商品分类
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<List<Category>>> GetCategories();

    }
}
