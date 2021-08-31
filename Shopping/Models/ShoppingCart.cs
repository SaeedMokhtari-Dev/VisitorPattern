using System.Collections.Generic;
using System.Linq;
using Shopping.Visitors;

namespace Shopping
{
    public class ShoppingCart
    {
        public List<ItemElement> ItemElements { get; set; }

        public ShoppingCart(params ItemElement[] itemElements)
       {
            ItemElements = itemElements.ToList();
        }
        public void AcceptShoppingCartVisitor(IShoppingCartVisitor visitor)
        {
            foreach (var itemElement in ItemElements)
            {
                itemElement.Accept(visitor);
            }
        }
    }
}