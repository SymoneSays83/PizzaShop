using System;
using Xunit;

namespace PizzaShop.Tests
{
    public class PizzaTests
    {
        private Pizza testPizza;

        public PizzaTests()
        {
            testPizza = new Pizza();
        }

        [Fact]
        public void CrustType_Should_Return_Pan_Crust()
        {
            testPizza.CrustType("pan");

            Assert.Equal("pan", testPizza.Crust);
        }

        [Fact]
        public void SauceType_Should_Return_White_Sauce()
        {
            testPizza.SauceType("white sauce");

            Assert.Equal("white sauce", testPizza.Sauce);
        }

        [Fact]
        public void CheeseLevel_Should_Return_Extra_Cheese()
        {
            testPizza.CheeseLevel("extra cheesy");

            Assert.Equal("extra cheesy", testPizza.Cheese);
        }

        [Fact]
        public void MeatToppings_Should_Return_Italian_Sausage()
        {
            testPizza.MeatToppings("italian sausage");

            Assert.Equal("italian sausage", testPizza.Meat);
        }

    }
}
