namespace BlazorEcommerce.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Prducts { get; set; }
        Task GetProducts { get; set; }
    }
}
