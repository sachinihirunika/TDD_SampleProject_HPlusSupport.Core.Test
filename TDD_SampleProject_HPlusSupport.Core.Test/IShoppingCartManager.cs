using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SampleProject_HPlusSupport.Core.Test
{
    public interface IShoppingCartManager
    {
        AddToCartItemResponse AddToCart(AddToCartItem request);
        public AddToCartRespose addToCartRespose(AddToCartItem request);
        public AddToCartItem[] GetCart(string cartId);
    }

  
}
