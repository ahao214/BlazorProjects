using AntDesign;
using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    public class ProductRepositoryMssql : IProduct
    {
        private readonly ICategory _category;
        public ProductRepositoryMssql(ICategory category)
        {
            _category = category;
        }

        public void Add(Product model)
        {
            SqlSugarHelper.Db.Insertable(model).ExecuteCommand();
        }

        /// <summary>
        /// 统计各个分类商品的数量
        /// </summary>
        /// <param name="caid"></param>
        /// <returns></returns>
        public int CalcCount(int caid)
        {
            Category ca = _category.GetModel(caid);
            string tmp = string.Empty;
            if (ca.ParentId == 0)
            {
                // 第一级分类 ,1,
                tmp = $",{ca.CategoryId},";
            }
            else
            {
                tmp = ca.CategoryPath + ca.CategoryId + ",";
            }
            // 下级分类的商品数
            int nextLevelCount = SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.Category.CategoryPath.StartsWith(tmp)).Count();
            // 本级分类的商品数
            int curLevelCount = SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.CategoryId == caid).Count();
            return nextLevelCount + curLevelCount;
        }

        public void Delete(int id)
        {
            SqlSugarHelper.Db.Deleteable<Product>().Where(pro => pro.ProductId == id).ExecuteCommand();
        }

        public List<Product> GetList(string searchKey = "")
        {
            return SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.ProductName.Contains(searchKey)).ToList();
        }

        /// <summary>
        /// 根据分类ID获取商品
        /// </summary>
        /// <param name="caid"></param>
        /// <returns></returns>
        public List<Product> GetListByCaId(int caid)
        {
            Category ca = _category.GetModel(caid);
            string tmp = string.Empty;
            if (ca.ParentId == 0)
            {
                // 第一级分类 ,1,
                tmp = $",{ca.CategoryId},";
            }
            else
            {
                tmp = ca.CategoryPath + ca.CategoryId + ",";
            }
            return SqlSugarHelper.Db.Queryable<Product>().Where(pro => pro.ProductId == caid|| pro.Category.CategoryPath.StartsWith(tmp)).ToList();
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
