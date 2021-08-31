using System;
using Shopping.Visitors;

namespace Shopping
{
    public class Fruit : ItemElement
    {
        public Fruit(long pricePerKg, long weight, string title)
        {
            PricePerKg = pricePerKg;
            Weight = weight;
            Title = title;
        }

        public long PricePerKg { get; }
        public override void Accept(IShoppingCartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}