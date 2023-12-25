using SqlSugar;

namespace Joker.LearnBlazor.WebService.Models
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class Category
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int CategoryId { get; set; } = 0;

        public string CategoryName { get; set; } = "";

        public int ParentId { get; set; } = 0;
        /// <summary>
        /// 分类路径 存储所有父类ID 如:1,2,3,4
        /// </summary>
        public string CategoryPath { get; set; } = string.Empty;

        [SugarColumn(IsIgnore =true)]
        public List<Category> Items { get; set; } = new List<Category>();

    }
}
