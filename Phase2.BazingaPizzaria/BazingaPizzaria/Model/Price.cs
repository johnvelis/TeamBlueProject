using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    class Price
    {
            
        #region Fields
        private Decimal _beverageSm;
        private Decimal _beverageMd;
        private Decimal _beverageLg;
        private Decimal _pizzaSm = 3.99M;
        private Decimal _pizzaMed = 7.99M;
        private Decimal _pizzaLg = 10.97M;
        private Decimal _pizzaXlg = 13.97M;

        #endregion

        #region Properties
        public Decimal BeverageSm
        {
            get { return _beverageSm; }
        }

        public Decimal BeverageMd
        {
            get { return _beverageMd; }
        }

        public Decimal BeverageLg
        {
            get { return _beverageLg; }
        }

        public Decimal PizzaSm
        {
            get { return _pizzaSm; }
        }

        public Decimal PizzaMed
        {
            get { return _pizzaMed; }
        }
       
        public Decimal PizzaLg
        {
            get { return _pizzaLg; }
        }
     
        public Decimal PizzaXlg
        {
            get { return _pizzaXlg; }
        }
 
        #endregion

        #region Constructors
        Price()
        {
            _beverageSm = 1.19;
            _beverageMd = 1.69;
            _beverageLg = 2.19;
        }
        #endregion
    }
}
