using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    public class CategoryRepositoryMssql : ICategory
    {
        public List<Category> GetList()
        {
            return SqlSugarHelper.Db.Queryable<Category>().ToList();
        }

        public List<string> GetMBXList(int caid)
        {
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
            var top = categories.Where(ca => ca.ParentId == 0).ToList();
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
            var sub = categories.Where(ca => ca.ParentId == model.CategoryId).ToList();
            foreach (var ca in sub)
            {
                ca.Items.Clear();
                Digui(ca, categories);
                model.Items.Add(ca);
            }
        }

    }
}
