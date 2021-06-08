using System;
using static System.Console;

namespace PizzaShop
{
    public class Toppings
    {
        public string ToppingName { get; set; }
        public string ToppingType { get; set; }

        public Toppings(string toppingName, string toppingType)
        {
            ToppingName = toppingName;
            ToppingType = toppingType;
        }

        public void MeatToppings()
        {
            if(ToppingName.Equals("bacon", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Mmm bacon!");
            }
            else if(ToppingName.Equals("chicken", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Chicken it is.");
            }
            else if(ToppingName.Equals("italian sausage", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Italian sausage, no problem.");
            }
            else 
            {
                ToppingName = "pepperoni";
                WriteLine("Is it even pizza without pepperoni?");
            }
        }

        public void VeggieToppings()
        {
            if (ToppingName.Equals("green pepper", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Green peppers, my favorite!");
            }
            else if(ToppingName.Equals("mushrooms", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Love me some 'shrooms!");
            }
            else if (ToppingName.Equals("onions", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Alright there onion boy, or girl.");
            }
            else if (ToppingName.Equals("black olives", StringComparison.OrdinalIgnoreCase))
            {
                WriteLine("Black olives don't get enough respect.");
            }
            else
            {
                ToppingName = "jalapenos";
                WriteLine("Someone likes it spicy! Jalapenos it is.");
            }
        }

    }
}
