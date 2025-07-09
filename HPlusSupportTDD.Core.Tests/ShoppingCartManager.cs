
namespace HPlusSupportTDD.Core.Tests
{
    internal class ShoppingCartManager
    {
        private List<AddToCartItem> _items;
        public ShoppingCartManager()
        {
            _items = new List<AddToCartItem>();
        }

        internal AddToCartResponse AddToCart(AddToCartRequest request)
        {
            var item = _items.Find(x => x.ArticleId == request.Item.ArticleId);
            if (item == null)
            {
                _items.Add(request.Item);
            }
            else
            {
                item.Quantity += request.Item.Quantity;
            }

            return new AddToCartResponse
            {
                Items = _items.ToArray()
            };
        }
    }
}