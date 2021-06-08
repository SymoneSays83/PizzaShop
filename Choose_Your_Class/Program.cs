/*This was a little too ambitious to not get help.  I'm familiar with arrays but really would like to get better with Lists.
 Because of this I did receive aid to implement running the cost/storing pizzas to the order, and some fancy formatting tips on
StringComparison in the Toppings class. Credit where it is due.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome the The Pizza Shoppe!");

            List<Pizza> myOrder = new List<Pizza>();
            Pizza myPizza = new Pizza();
            bool stillOrdering = true;
            while (stillOrdering)
            {

                WriteLine("Our $5 standard pizza has a hand-tossed crust, zesty marinara, and just enough cheese.\n");

                WriteLine("What would you like to do?");
                WriteLine("1. Change crust");
                WriteLine("2. Choose your cheese level");
                WriteLine("3. Change sauce");
                WriteLine("4. Add meat toppings");
                WriteLine("5. Add veggie toppings");
                WriteLine("6. Add another pizza");
                WriteLine("7. Checkout and Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        WriteLine("Enter pan, thin, or press enter to stay with hand-tossed: ");
                        string input = ReadLine();
                        myPizza.CrustType(input);
                        break;
                    case "2":
                        WriteLine("Enter light cheese, extra cheesy, or enter to stay with that just right amount of cheese: ");
                        input = ReadLine();
                        myPizza.CheeseLevel(input);
                        break;
                    case "3":
                        WriteLine("Enter white sauce or enter to keep that zesty marinara: ");
                        input = ReadLine();
                        myPizza.SauceType(input);
                        break;
                    case "4":
                        WriteLine("Enter bacon, chicken, italian sausage, or enter for pepperoni: ");
                        input = ReadLine();
                        var meatTopping = new Toppings(input, "meat");
                        meatTopping.MeatToppings();
                        myPizza.AddTopping(meatTopping);
                        break;
                    case "5":
                        WriteLine("Enter green pepper, mushrooms, onions, black olives, or enter for jalapenos");
                        input = ReadLine();
                        var veggieTopping = new Toppings(input, "veggie");
                        veggieTopping.VeggieToppings();
                        myPizza.AddTopping(veggieTopping);
                        break;
                    case "6":
                        myOrder.Add(myPizza);
                        myPizza = new Pizza();
                        WriteLine("Okay, let's add another pizza to your order");
                        break;
                    case "7":
                        double total = 0;
                        myOrder.Add(myPizza);
                        foreach(var pizza in myOrder) 
                        {
                            total += 5;
                            total += pizza.Toppings.Where(x => x.ToppingType == "meat").Count() * .75;
                            total += pizza.Toppings.Where(x => x.ToppingType == "veggie").Count() * .25;
                            WriteLine(pizza.ToString());
                        }
                        WriteLine($"You ordered {myOrder.Count} pizza(s) and the total comes to {total:C}.");
                        stillOrdering = false;
                        break;
                    default:
                        WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
