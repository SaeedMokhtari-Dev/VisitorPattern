using System;

namespace Shopping.Visitors
{
    public class WeightVisitor: IShoppingCartVisitor
    {
        public long Weight { get; private set; }
        public void Visit(Book book)
        {
            Weight += book.Weight;
            Console.WriteLine($"book: ${book.Title} has weight of {book.Weight}, and turned finalWeight into {Weight}");
        }

        public void Visit(Fruit fruit)
        {
            Weight += fruit.Weight;
            Console.WriteLine($"fruit: ${fruit.Title} has weight of {fruit.Weight}, and turned finalWeight into {Weight}");
        }
    }
}