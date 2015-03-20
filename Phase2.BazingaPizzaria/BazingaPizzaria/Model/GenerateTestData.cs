using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    class GenerateTestData
    {
        internal static Order GenerateTestOrderData()
        {
            //
            // generate test order
            //
            Order newOrder = new Order();
            newOrder.LastName = "Flintstone";
            newOrder.FirstName = "Fred";
            newOrder.Address = "1313 Cobblestone Way";
            newOrder.City = "Bedrock";
            newOrder.StateProvince = "Stoneville";
            newOrder.Zip = "55555";
            newOrder.Email = "fred@stonemail.com";
            newOrder.PhoneNumber = "555-555-5555";

            newOrder.CCName = "Fred Flintstone";
            newOrder.CCNumber = "1111222233334444";
            newOrder.CCExpMonth = 5;
            newOrder.CCExpYear = 2017;
            newOrder.CCCVVCode = 345;

            //
            // genearate pizza for order with toppings
            //
            Pizza pizzaOne = new Pizza();
            pizzaOne.PizzaID = 0001;
            pizzaOne.Size = "Large";
            pizzaOne.Crust = "Garlic";
            pizzaOne.IsSpecialty = false;
            pizzaOne.Quantity = 1;
            pizzaOne.PizzaPrice = 17.73M;

            //
            // add toppings to pizzaOne
            //
            Pizza.Topping firstTopping = Pizza.Topping.Pepperoni;
            Pizza.Topping secondTopping = Pizza.Topping.Ham;
            Pizza.Topping thirdTopping = Pizza.Topping.ItalianSausage;
            pizzaOne.PizzaToppings.Add(firstTopping);
            pizzaOne.PizzaToppings.Add(secondTopping);
            pizzaOne.PizzaToppings.Add(thirdTopping);

            //
            // genearate specialty pizza for order (2 pizzas)
            //
            Pizza pizzaTwo = new Pizza();
            pizzaOne.PizzaID = 0002;
            pizzaOne.Size = "Small";
            pizzaOne.Crust = "Cheesy";
            pizzaOne.IsSpecialty = true;
            pizzaOne.Quantity = 2;
            pizzaOne.PizzaPrice = 34.73M;
            
            //
            // add pizzaOne and pizzaTwo to testOrder
            //
            newOrder.PizzaPurchase.Add(pizzaOne);
            newOrder.PizzaPurchase.Add(pizzaTwo);

            //
            // generate beverages for order
            //
            //Beverage beverageOne = new Beverage("Coke", Beverage.BevSize.Large, 2);
            //Beverage beverageTwo = new Beverage("Orange", Beverage.BevSize.Small, 1);
            //Beverage beverageThree = new Beverage("Three River IPA", Beverage.BevSize.XL, 4);

            //
            // add beverages to testOrder
            //
            //newOrder.BeveragePurchase.Add(beverageOne);
            //newOrder.BeveragePurchase.Add(beverageTwo);
            //newOrder.BeveragePurchase.Add(beverageThree);

            return newOrder;
        }
    }
}
