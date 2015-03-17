using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Beverage
    {
        private int _beverageID;
        private string _name;
        private byte _quantity;
        //private Enum _size;

        public int BeverageID
        {
            get { return _beverageID; }
            set { _beverageID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public byte Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        //public Enumerable Size
        //{
        //    get { return _size; }
        //    set { _size = value; }
        //}

        
    }
}
