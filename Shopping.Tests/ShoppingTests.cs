using System;
using FluentAssertions;
using Shopping.Visitors;
using Xunit;

namespace Shopping.Tests
{
    public class ShoppingTests
    {
        [Fact]
        public void ShoppingCart_constructor_should_create_based_on_args()
        {
            var shoppingCart = new ShoppingCart(new Book(20, "1234", 10),
                new Book(100, "5678", 120), new Fruit(10, 2, "Banana"),
                new Fruit(5, 5, "Apple"));

            shoppingCart.ItemElements.Should().HaveCount(4);
        }
        [Fact]
        public void PriceVisitor_should_get_price_of_shopping_cart()
        {
            var shoppingCart = new ShoppingCart(new Book(20, "1234", 10),
                new Book(100, "5678", 120), new Fruit(10, 2, "Banana"),
                new Fruit(5, 5, "Apple"));

            PriceVisitor priceVisitor = new PriceVisitor();
            shoppingCart.AcceptShoppingCartVisitor(priceVisitor);
            priceVisitor.Price.Should().Be(40);
        }
        [Fact]
        public void WeightVisitor_should_get_weight_of_shopping_cart()
        {
            var shoppingCart = new ShoppingCart(new Book(20, "1234", 10),
                new Book(100, "5678", 120), new Fruit(10, 2, "Banana"),
                new Fruit(5, 5, "Apple"));

            WeightVisitor weightVisitor = new WeightVisitor();
            shoppingCart.AcceptShoppingCartVisitor(weightVisitor);
            weightVisitor.Weight.Should().Be(137);
        }
    }
}