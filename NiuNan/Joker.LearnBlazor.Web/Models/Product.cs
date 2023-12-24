using System.ComponentModel.DataAnnotations;

namespace Joker.LearnBlazor.Web.Models
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "商品名称")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "商品图片")]
        public string ThumbnailImage { get; set; }



    }
}
