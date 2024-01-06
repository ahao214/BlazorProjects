namespace BlazorEcommerce.Client.Services.CartServices
{
    /// <summary>
    /// 购物车服务接口
    /// </summary>
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        Task<List <CartItem>> GetCartItems(); 

    }
}
