using TDD_SampleProject_HPlusSupport.Core.Test;

namespace TDD_SampleProject_HPlusSupport.Core
{
    public class ShoppingCartManager : IShoppingCartManager
    {
        private List<AddToCartItem> _shoppingCart;

        public ShoppingCartManager(List<AddToCartItem> shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public ShoppingCartManager()
        {
        }

        public AddToCartItemResponse AddToCart(AddToCartItem request)
            {
            var item = _shoppingCart.Find(i => i.ArticleId == request.Item.ArticleId);
            
            if (item != null)
            {
                item.Quantity += request.Item.Quantity;
            }
            else {
                _shoppingCart.Add(request.Item); 
            }

            return new AddToCartItemResponse()
            {
                //Array of Item
                Items = _shoppingCart.ToArray(),
                // Single Item
               // Items= new AddToCartItem[] { request.Item }
            };
            throw new NotImplementedException();
        }

        public AddToCartRespose addToCartRespose(AddToCartItem request)
        {
            throw new NotImplementedException();
        }

        public AddToCartItem[] GetCart(string cartId)
        {
            throw new NotImplementedException();
        }
    }
}