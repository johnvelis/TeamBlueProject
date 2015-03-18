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
            Order testOrder = new Order();
            testOrder.LastName = "Flintstone";
            testOrder.FirstName = "Fred";
            testOrder.Address = "1313 Cobblestone Way";
            testOrder.City = "Bedrock";
            testOrder.StateProvince = "Stoneville";
            testOrder.Zip = "55555";
            testOrder.Email = "fred@stonemail.com";

            testOrder.CCName = "Fred Flintstone";
            testOrder.CCNumber = "1111222233334444";
            testOrder.CCExpMonth = 5;
            testOrder.CCExpYear = 2017;
            testOrder.CCCVVCode = 345;

            //
            // genearate pizza for order with toppings
            //
            Pizza pizzaOne = new Pizza();
            pizzaOne.PizzaID = 0001;
            pizzaOne.Size = "Large";
            pizzaOne.Crust = "Garlic";
            pizzaOne.IsSpecialty = false;
            pizzaOne.Quantity = 1;

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

            //
            // add pizzaOne and pizzaTwo to testOrder

            return testOrder;
        }
    }
}
