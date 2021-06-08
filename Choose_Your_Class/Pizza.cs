using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace PizzaShop
{
    public class Pizza
    {
        // create 5 properties for this class
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public List<Toppings> Toppings { get; } = new List<Toppings>();

        // create methods that implement properties
        public Pizza() 
        {
            Crust = "hand-tossed";
            Sauce = "marinara";
            Cheese = "regular cheese";
        }

        // sets crust type
        public void CrustType(string crust)
        {
            Crust = crust;
            if(crust == "pan")
            {
                WriteLine("Pan crust it is for the bread lover in all of us!");
            }
            else if(crust == "thin")
            {
                WriteLine("Thin crust crispy, crunchy goodness!");
            }
            else
            {
                Crust = "hand-tossed";
                WriteLine("Hand-tossed, the tried and true.");
            }
        }

        public void CheeseLevel(string cheese)
        {
            Cheese = cheese;
            if(cheese == "light cheese")
            {
                WriteLine("Light cheese it is.");
            }
            else if(cheese == "extra cheesy")
            {
                WriteLine("Oh that extra cheesy goodness!");
            }
            Cheese = "regular cheese";
            WriteLine("It really is the right amount.");
        }

        public void SauceType(string sauce)
        {
            Sauce = sauce;
            if (sauce == "white sauce")
            {
                WriteLine("Garlicky, tasty goodness!");
            }
            Sauce = "marinara";
            WriteLine("Keep it saucy, my friend!");
        }

        public void AddTopping(Toppings newTopping)
        {
            Toppings.Add(newTopping);
        }

        public override string ToString()
        {
            return $"This pizza has {Crust} crust, is {Cheese}, with {Sauce}, and comes with {string.Join(", ", Toppings.Select(x => x.ToppingName))}";
        }

    }
}
