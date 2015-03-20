using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Beverage
    {
        public enum BevSize
        {
            Small,
            Medium,
            Large,
            XL
        }

        private string _name;
        private BevSize _beverageSize;
        private int _quantity;
        private decimal _price;
        private decimal _basePrice;

        public decimal BasePrice
        {
            get { return _basePrice; }
        }


        public decimal BevPrice
        {
            get { return _price; }
            set { _price = value; }
        }

        public string SizeName { get { return _beverageSize + " " + _name; } }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public BevSize BeverageSize
        {
            get { return _beverageSize; }
            set { _beverageSize = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Beverage()
        {

        }

        public Beverage(string name, BevSize beverageSize, int quantity, decimal price)
        {
            _name = name;
            _beverageSize = beverageSize;
            _quantity = quantity;
            _price = price;
            _basePrice = price;
        }

    }
}
