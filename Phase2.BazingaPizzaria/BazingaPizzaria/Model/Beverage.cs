using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Beverage
    {

        private string _name;
        private string _size;
        private int _quantity;
        public enum Size { Small, Medium, Large, XL}

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Size 
        { 
            get; 
            set; 
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

    }
}
