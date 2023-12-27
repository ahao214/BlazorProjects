
namespace BlazorEcommerce.Server.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 商品分类接口
        /// </summary>
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
            
        }
    }
}
