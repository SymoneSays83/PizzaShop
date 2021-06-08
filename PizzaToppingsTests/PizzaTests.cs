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
        public void CrustType_Should_Return_Default_Crust_If_Crust_Is_Not_Specified()
        {
            testPizza.CrustType(string.Empty);

            Assert.Equal("hand-tossed", testPizza.Crust);
        }

        [Fact]
        public void SauceType_Should_Return_Default_Sauce_If_Sauce_Is_Not_Specified()
        {
            testPizza.SauceType(string.Empty);

            Assert.Equal("marinara", testPizza.Sauce);
        }

        [Fact]
        public void CheeseLevel_Should_Return_Default_Cheese_If_Cheese_Is_Not_Specified()
        {
            testPizza.CheeseLevel(string.Empty);

            Assert.Equal("regular cheese", testPizza.Cheese);
        }
    }
}
