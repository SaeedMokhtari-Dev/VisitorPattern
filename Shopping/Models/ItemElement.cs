using Shopping.Visitors;

namespace Shopping
{
    public abstract class ItemElement
    {
        public abstract void Accept(IShoppingCartVisitor visitor);
        public string Title { get; set; }
        public long Weight { get; set; }
    }
}