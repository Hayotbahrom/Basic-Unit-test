
namespace HPlusSupportTDD.Core.Tests;

internal class ShoppingCartManager : IShoppingCartManager
{
    private List<AddToCartItem> _items;
    public ShoppingCartManager()
    {
        _items = new List<AddToCartItem>();
    }

    public AddToCartItem[] GetCartItems()
    {
        return _items.ToArray();
    }

    public AddToCartResponse AddToCart(AddToCartRequest request)
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