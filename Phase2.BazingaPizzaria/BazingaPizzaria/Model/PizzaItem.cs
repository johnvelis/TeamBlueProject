using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    class PizzaItem
    {
        #region Fields
        private int _pizzaItemID;
        private String _name;
        private Boolean _isExtraCost;
        private Double _extraCost;
        #endregion

        #region Properties
        public int PizzaItemID
        {
            get { return _pizzaItemID; }
            set { _pizzaItemID = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Boolean IsExtraCost
        {
            get { return _isExtraCost; }
            set { _isExtraCost = value; }
        }

        public Double ExtraCost
        {
            get { return _extraCost; }
            set { _extraCost = value; }
        }
        #endregion

        #region Constructors

        public PizzaItem()
        {

        }

        public PizzaItem(int pizzaItemID, String name, Boolean isExtraCost, Double extraCost)
        {
            this.PizzaItemID = pizzaItemID;
            this.Name = name;
            this.IsExtraCost = isExtraCost;
            this.ExtraCost = extraCost;
        }
        #endregion
    }
}
