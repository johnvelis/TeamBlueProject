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

            return testOrder;
        }
    }
}
