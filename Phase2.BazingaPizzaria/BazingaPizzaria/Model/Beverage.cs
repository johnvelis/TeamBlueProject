using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Beverage
    {
        public enum Size
        {
            Small,
            Medium,
            Large,
            XL
        }

        private string _name;
        private Size _beverageSize;
        private int _quantity;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Size BeverageSize
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

        public Beverage(string name, Size beverageSize, int quantity)
        {
            _name = name;
            _beverageSize = beverageSize;
            _quantity = quantity;
        }

    }
}
