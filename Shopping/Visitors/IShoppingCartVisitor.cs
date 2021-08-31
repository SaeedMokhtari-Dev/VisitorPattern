namespace Shopping.Visitors
{
    public interface IShoppingCartVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }
}