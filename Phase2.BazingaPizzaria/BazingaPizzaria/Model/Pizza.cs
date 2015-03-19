using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Pizza
    {
        #region ENUM

        public enum Topping
        {
            Pepperoni,
            ItalianSausage,
            Ham,
            Mushrooms,
            Olives,
            GreenPeppers,

        };

        public enum SpecialtyName
        {
            UltimateCheese,
            PiledHighPepperoni,
            MoundsofMeat,
            VeggiePatch,
            SuperSupreme,
        };
        #endregion

        #region FIELDS

        private int _pizzaID;
        private string _size;
        private string _crust;
        private bool _isSpecialty;
        private SpecialtyName _specialtyName;
        private byte _quantity;
        private decimal _pizzaPrice;

        private List<Topping> _pizzaToppings = new List<Topping>();

        #endregion

        #region PROPERTIES


        public int PizzaID
        {
            get { return _pizzaID; }
            set { _pizzaID = value; }
        }


        public string Size
        {
            get { return _size; }
            set { string _size = value; }
        }


        public string Crust
        {
            get { return _crust; }
            set { _crust = value; }
        }

        public bool IsSpecialty
        {
            get { return _isSpecialty; }
            set { _isSpecialty = value; }
        }

        public SpecialtyName PizzaSpecialtyName
        {
            get { return _specialtyName; }
            set { _specialtyName = value; }
        }

        public byte Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public List<Topping> PizzaToppings
        {
            get { return _pizzaToppings; }
            set { _pizzaToppings = value; }
        }
        

        public decimal PizzaPrice
        {
             get { return _pizzaPrice; }
            set { _pizzaPrice = value; }
        }
        

        #endregion

        #region CONSTUCTORS

        public Pizza()
        {
            _pizzaID = 0001;
            _quantity = 1;
        }

        #endregion
    }
}
