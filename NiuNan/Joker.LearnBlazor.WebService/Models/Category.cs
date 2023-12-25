namespace Joker.LearnBlazor.WebService.Models
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; } = 0;

        public string CategoryName { get; set; } = "";

        public int ParentId { get; set; } = 0;
        /// <summary>
        /// 分类路径 存储所有父类ID 如:1,2,3,4
        /// </summary>
        public string CategoryPath { get; set; } = string.Empty;

        public List<Category> Items { get; set; } = new List<Category>();

    }
}
