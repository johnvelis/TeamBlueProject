using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazingaPizzaria.Model;

namespace BazingaPizzaria.Model
{
    public class Order
    {
        #region FIELDS
        private int _orderID;
        private DateTime _dateTime;
        private int _number;
        private String _lastName;
        private String _firstName;
        private String _address;
        private String _city;
        private String _stateProvince;
        private String _zip;
        private String _email;
        private String _phoneNumber;
        private String _ccName;
        private String _ccNumber;
        private int _ccExpMonth;
        private int _ccExpYear;
        private int _ccCVVCode;
        private bool _dineIn;

        private List<Pizza> _pizza = new List<Pizza>();
        private List<Beverage> _beverage = new List<Beverage>();


        #endregion

        #region PROPERTIES
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        public DateTime Date
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        public String StateProvince
        {
            get { return _stateProvince; }
            set { _stateProvince = value; }
        }
        public String Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public String CCName
        {
            get { return _ccName; }
            set { _ccName = value; }
        }

        public String CCNumber
        {
            get { return _ccNumber; }
            set { _ccNumber = value; }
        }

        public int CCExpMonth
        {
            get { return _ccExpMonth; }
            set { _ccExpMonth = value; }
        }

        public int CCExpYear
        {
            get { return _ccExpYear; }
            set { _ccExpYear = value; }
        }

        public int CCCVVCode
        {
            get { return _ccCVVCode; }
            set { _ccCVVCode = value; }
        }

        public bool DineIn { get; set; }

        public List<Pizza> PizzaPurchase
        {
            get { return _pizza; }
            set { _pizza = value; }
        }
        public List<Beverage> BeveragePurchase
        {
            get { return _beverage; }
            set { _beverage = value; }
        }
        #endregion

        #region METHODS
        // return a string with the full name
        public string FullName()
        {
            return (_firstName + " " + _lastName);
        }

        // return a string with the full address
        public string FullAddress()
        {
            return (
                _address + "\r\n" +
                _city + ", " + _stateProvince + " " + _zip);
        }

        // return a string with the full credit card expiration date
        public string FullCCExpDate()
        {
            return (
                _ccExpMonth + "/" + _ccExpYear);
        }

        // calculate the subtotal for the pizzas
        public decimal PizzaSubtotal()
        {
            decimal pizzaSubtotal = 0;
            foreach (Pizza pizza in _pizza)
            {
                pizzaSubtotal = pizzaSubtotal + pizza.PizzaPrice;
            }

            return (pizzaSubtotal);
        }

        // calculate the subtotal for the pizzas
        public decimal BeverageSubtotal()
        {
            decimal beverageSubtotal = 0;
            foreach (Beverage beverage in _beverage)
            {
                // fix with correct pricing [JOHN]
                beverageSubtotal = beverageSubtotal + beverage.Quantity;
            }

            return (beverageSubtotal);
        }

        #endregion

        #region Constructors
        public Order()
        {

        }

        public Order(string FirstName, bool DineIn)
        {
            _firstName = FirstName;
            _dineIn = DineIn;
        }

        public Order(string FirstName, bool DineIn, string PhoneNumber)
        {
            _firstName = FirstName;
            _dineIn = DineIn;
            _phoneNumber = PhoneNumber;
        }
      
        #endregion
    }
}
