namespace Joker.LearnBlazor.Web.Models
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int ParentId { get; set; }

        public List<Category> Items { get; set; }

    }
}
