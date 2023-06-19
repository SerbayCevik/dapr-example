using DaprShop.ShoppingCart.API.Domain;

namespace DaprShop.ShoppingCart.API.Services
{
    public interface IShoppingCartService
    {
        Task<Domain.ShoppingCart> GetShoppingCartAsync(string userId);
        Task AddItemToShoppingCartAsync(string userId, ShoppingCartItem item);
    }
}
