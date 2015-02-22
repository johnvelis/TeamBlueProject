using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria

{
    public class Order
    {
        #region FIELDS
        private int _orderID;
        private DateTime _date;
        private int _number;
        private int _customerID;       
        #endregion

        #region PROPERTIES
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        
        
        public DateTime OrderDate
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public int customerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        #endregion

    }
}
