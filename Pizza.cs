using System;
using static System.Console;

namespace PizzaShop
{
    public class Pizza
    {
        // create 5 properties for this class
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public string Meat { get; set; }
        public string Veggie { get; set; }
        public string Sides { get; set; }

        // create methods that implement properties
        public Pizza() { }

        // sets crust type
        public string CrustType(string crust)
        {
            Crust = crust;
            if(crust == "pan")
            {
                WriteLine("For the bread love in all of us!");
                return "pan";
            }
            else if(crust == "thin")
            {
                WriteLine("Crispy, crunchy goodness!");
                return "thin";
            }
            else
            {
                WriteLine("The tried and true.");
                return "hand-Tossed";
            }
        }

        public string SauceType(string sauce)
        {
            Sauce = sauce;
            if(sauce == "white sauce")
            {
                return "white sauce";
            }
            return "marinara";
        }

        public string CheeseLevel(string cheese)
        {
            Cheese = cheese;
            if(cheese == "light cheese")
            {
                return "light cheese";
            }
            else if(cheese == "extra cheesy")
            {
                return "extra cheesy";
            }
            return "regular cheese";
        }

        public string MeatToppings(string meat)
        {
            Meat = meat;
            return "italian sausage";
        }

    }
}
