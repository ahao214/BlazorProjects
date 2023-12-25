using AntDesign;
using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    public class ProductRepositoryMssql : IProduct
    {
        public void Add(Product model)
        {
            SqlSugarHelper.Db.Insertable(model).ExecuteCommand();
        }

        public int CalcCount(int caid)
        {
            return SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.CategoryId == caid).Count();
        }

        public void Delete(int id)
        {
            SqlSugarHelper.Db.Deleteable<Product>().Where(pro => pro.ProductId == id).ExecuteCommand();
        }

        public List<Product> GetList(string searchKey = "")
        {
            return SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.ProductName.Contains(searchKey)).ToList();
        }

        public List<Product> GetListByCaId(int caid)
        {
            return SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.ProductId == caid).ToList();
        }

        public Product GetModel(int id)
        {
            return SqlSugarHelper.Db.Queryable<Product>().Single(pro => pro.ProductId == id);
        }

        public void Update(Product model)
        {
            SqlSugarHelper.Db.Updateable(model).ExecuteCommand();
        }
    }
}
