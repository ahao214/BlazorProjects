using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    /// <summary>
    /// 商品接口
    /// </summary>
    public interface IProduct
    {
        void Add(Product model);
        void Delete(int id);
        void Update(Product model);
        List<Product> GetList(string searchKey="");
        Product GetModel(int id);

        List<Product> GetListByCaId(int caid);

        int CalcCount(int caid);

        List<Product> GetListPae(string searchKey = "", int caId = 0, int pageSize = 8, int pageIndex = 1);

        int CalcCountPage(string searchKey = "", int caId = 0);
    }
}
