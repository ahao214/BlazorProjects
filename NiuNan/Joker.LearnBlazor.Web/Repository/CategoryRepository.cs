using Joker.LearnBlazor.Web.Models;

namespace Joker.LearnBlazor.Web.Repository
{
    public class CategoryRepository : ICategory
    {
        private List<Category> categories = new List<Category>();

        public CategoryRepository()
        {           
            categories = new List<Category>()
             {
                 new Category(){ CategoryId=1,CategoryName="电子产品",ParentId=0,Items=new List<Category>()
                 {
                     new Category(){CategoryId=11,CategoryName="手机",ParentId=1},
                     new Category(){CategoryId=12,CategoryName="电脑",ParentId=1},
                     new Category(){CategoryId=13,CategoryName="平板",ParentId=1},
                 } },
                  new Category(){ CategoryId=2,CategoryName="生活用品",ParentId=0,Items=new List<Category>()
                 {
                     new Category(){CategoryId=21,CategoryName="牙签",ParentId=2},
                     new Category(){CategoryId=22,CategoryName="抽纸",ParentId=2},
                 } },
             };
        }

        public List<Category> GetList()
        {
            return categories;
        }

        public List<string> GetMBXList(int caid)
        {
            throw new NotImplementedException();
        }

        public Category GetModel(int caid)
        {
            return categories.SingleOrDefault(ca => ca.CategoryId == caid);
        }

        public List<Category> GetTreeModel()
        {
            List<Category> list = new List<Category>();
            // 取出父级节点
            var top = categories.Where(ca => ca.ParentId == 0).ToList();
            foreach (var oneca in top)
            {
                Digui(oneca);
                list.Add(oneca);
            }
            return list;
        }

        /// <summary>
        /// 递归添加下级节点
        /// </summary>
        /// <param name="model"></param>
        private void Digui(Category model)
        {
            var sub = categories.Where(ca => ca.ParentId == model.CategoryId).ToList();
            foreach (var ca in sub)
            {
                Digui(ca);
                model.Items.Add(ca);
            }
        }
    }
}
