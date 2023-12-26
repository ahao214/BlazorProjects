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

        [Navigate(NavigateType.OneToMany, nameof(ProductImages.ProductId))] // 一个商品对应多张图片
        public List<ProductImages> Images { get; set; }
        /// <summary>
        /// 商品条码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 商品品牌
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// 使用感受
        /// </summary>
        public string UseFell { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime LastUpdateTime { get; set; } = DateTime.Now;
    
    }

}
