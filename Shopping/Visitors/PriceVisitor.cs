using System;

namespace Shopping.Visitors
{
    public class PriceVisitor: IShoppingCartVisitor
    {
        public long Price { get; private set; } = 0;
        public void Visit(Book book)
        {
            Price += book.Price;
            if (book.Price >= 50)
                Price =- 5;
            Console.WriteLine($"book: ${book.Title} has price of {book.Price}, and turned finalPrice into {Price}");
        }

        public void Visit(Fruit fruit)
        {
            var price = fruit.PricePerKg * fruit.Weight;
            Price += price;
            Console.WriteLine($"fruit: ${fruit.Title} has price of {price}, and turned finalPrice into {Price}");
        }
    }
}