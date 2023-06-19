namespace DaprShop.Contracts
{
    public class ProductItemAddedToShoppingCartEvent
    {
        public string UserId { get; set; } = String.Empty;
        public string ProductId { get; set; } = String.Empty;
    }
}