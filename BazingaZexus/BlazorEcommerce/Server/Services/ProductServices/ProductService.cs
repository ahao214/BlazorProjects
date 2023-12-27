
namespace BlazorEcommerce.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 获取产品详情
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(p=>p.Variants)
                .ThenInclude(v=>v.ProductType)
                .FirstOrDefaultAsync(p=>p.Id== productId);

            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry,but this product does not exist";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        /// <summary>
        /// 获取产品数据
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p=>p.Variants).ToListAsync()
            };
            return response;
        }

        /// <summary>
        /// 根据分类获取产品数据
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).Include(p=>p.Variants).ToListAsync()
            };
            return response;
        }
    }
}
