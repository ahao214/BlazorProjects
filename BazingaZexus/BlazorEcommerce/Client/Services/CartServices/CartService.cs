
using Blazored.LocalStorage;

namespace BlazorEcommerce.Client.Services.CartServices
{
    /// <summary>
    /// 购物车服务
    /// </summary>
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;

        public CartService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public event Action OnChange;

        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <param name="cartItem"></param>
        /// <returns></returns>
        public async Task AddToCart(CartItem cartItem)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            cart.Add(cartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        /// <summary>
        /// 获取购物车中的产品
        /// </summary>
        /// <returns></returns>
        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            return cart;
        }
    }
}
