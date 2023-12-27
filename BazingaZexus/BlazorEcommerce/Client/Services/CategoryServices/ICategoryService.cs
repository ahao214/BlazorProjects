namespace BlazorEcommerce.Client.Services.CategoryServices
{
    /// <summary>
    /// 获取商品分类接口
    /// </summary>
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }


        /// <summary>
        /// 获取所有商品分类
        /// </summary>
        /// <returns></returns>
        Task GetCategories();

    }
}
