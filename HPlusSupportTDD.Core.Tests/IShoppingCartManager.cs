namespace HPlusSupportTDD.Core.Tests
{
    internal interface IShoppingCartManager
    {
        public AddToCartResponse AddToCart(AddToCartRequest request);
        public AddToCartItem[] GetCartItems();
    }
}
