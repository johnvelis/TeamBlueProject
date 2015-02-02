using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsAndObjects
{
    public class Order
    {
        #region FIELDS
        private String _firstName;
        private String _lastName;
        private DateTime _orderDate;
        private String _specialtyPizzaName;
        private int _pizzaSize;

        

        
        #endregion

        #region PROPERTIES
        public String firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        
        public String lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
        #endregion

        public String specialtyPizzaName
        {
            get { return _specialtyPizzaName; }
            set { _specialtyPizzaName = value; }
        }

        public int pizzaSize
        {
            get { return _pizzaSize; }
            set { _pizzaSize = value; }
        }
    }
}
