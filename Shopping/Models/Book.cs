using Shopping.Visitors;

namespace Shopping
{
    public class Book : ItemElement
    {
        public Book(long price, string title, long weight)
        {
            Price = price;
            Title = title;
            Weight = weight;
        }

        public long Price { get; }
        public override void Accept(IShoppingCartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}