using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    public class CategoryRepositoryMssql : ICategory
    {

        public void Add(Category model)
        {
            SqlSugarHelper.Db.Insertable(model).ExecuteCommand();
        }

        public void Delete(int id)
        {
            // 有下级的时候不能删除
            int nextLevel = SqlSugarHelper.Db.Queryable<Category>().Where(c => c.ParentId == id).Count();
            if (nextLevel > 0)
            {
                throw new Exception("该分类有下级,不可删除");
            }
            // 有商品的时候不能删除
            int proCount = SqlSugarHelper.Db.Queryable<Product>().Where(p => p.CategoryId == id).Count();
            if (proCount > 0)
            {
                throw new Exception("该分类有商品,不可删除");
            }
            SqlSugarHelper.Db.Deleteable<Category>(a => a.CategoryId == id).ExecuteCommand();
        }

        public void Update(Category modle)
        {
            SqlSugarHelper.Db.Updateable(modle).ExecuteCommand();
        }

        public List<Category> GetList()
        {
            return SqlSugarHelper.Db.Queryable<Category>().ToList();
        }

        public List<string> GetMBXList(int caid)
        {
            if (caid == 0)
            {
                return new List<string>()
                {
                    "全部商品"
                };
            }
            List<string> list = new List<string>();
            Category ca = GetModel(caid);
            string[] caids = ca.CategoryPath.Split(',');
            foreach (var item in caids)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                Category temp = GetModel(int.Parse(item));
                list.Add(temp.CategoryName);
            }
            list.Add(ca.CategoryName);
            return list;
        }

        public Category GetModel(int caid)
        {
            return SqlSugarHelper.Db.Queryable<Category>().Single(ca => ca.CategoryId == caid);
        }

        public List<Category> GetTreeModel()
        {
            List<Category> categories = GetList();
            List<Category> list = new List<Category>();
            // 取出父级节点
            var top = categories.Where(ca => ca.ParentId == 0).OrderBy(ca => ca.Sort).ToList();
            foreach (var oneca in top)
            {
                oneca.Items.Clear();
                Digui(oneca, categories);
                list.Add(oneca);
            }
            return list;
        }



        /// <summary>
        /// 递归添加下级节点
        /// </summary>
        /// <param name="model"></param>
        private void Digui(Category model, List<Category> categories)
        {
            var sub = categories.Where(ca => ca.ParentId == model.CategoryId).OrderBy(ca => ca.Sort).ToList();
            foreach (var ca in sub)
            {
                ca.Items.Clear();
                Digui(ca, categories);
                model.Items.Add(ca);
            }
        }

    }
}
