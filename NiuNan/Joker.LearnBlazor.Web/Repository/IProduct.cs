using Joker.LearnBlazor.Web.Models;

namespace Joker.LearnBlazor.Web.Repository
{
    /// <summary>
    /// 商品接口
    /// </summary>
    public interface IProduct
    {
        void Add(Product model);
        void Delete(int id);
        void Update(Product model);
        List<Product> GetList();
        Product GetModel(int id);
    }
}
