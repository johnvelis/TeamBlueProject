using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    class GenerateTestData
    {
        internal static Customer GenerateTestCustomerData()
        {
            Customer testCustomer = new Customer();

            testCustomer.CustomerID = 1;
            testCustomer.UserName = "fredflintstone";
            testCustomer.Password = "password1234";

            testCustomer.LastName = "Flintstone";
            testCustomer.FirstName = "Fred";
            testCustomer.Address = "1313 Cobblestone Way";
            testCustomer.City = "Bedrock";
            testCustomer.StateProvince = "Stoneville";
            testCustomer.Zip = "55555";
            testCustomer.Email = "fred@stonemail.com";

            testCustomer.CCName = "Fred Flintstone";
            testCustomer.CCNumber = "1111222233334444";
            testCustomer.CCExpMonth = 5;
            testCustomer.CCExpYear = 2017;
            testCustomer.CCCVVCode = 345;

            return testCustomer;
        }
    }
}
