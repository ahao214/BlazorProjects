using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace Joker.LearnBlazor.WebService.Models
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class Product
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ProductId { get; set; } = 0;
        [Required]
        [Display(Name = "商品名称")]
        public string ProductName { get; set; } = "";

        [Display(Name = "商品图片")]
        public string ThumbnailImage { get; set; } = "";
        [Display(Name = "商品分类")]
        public int CategoryId { get; set; } = 0;

        [Navigate(NavigateType.OneToOne, nameof(CategoryId))]
        public Category Category { get; set; }

    }
}
