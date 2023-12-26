namespace Joker.LearnBlazor.WebService.Models
{
    /// <summary>
    /// 商品图片
    /// </summary>
    public class ProductImages
    {
        /// <summary>
        /// 主键自增
        /// </summary>
        public int ImageId { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 图片标题
        /// </summary>
        public string Title { get; set; }
    }
}
