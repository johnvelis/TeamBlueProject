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
            JustCheese
        };

        public enum SpecialtyName
        {
            UltimateCheese,
            PiledHighPepperoni,
            MoundsofMeat,
            VeggiePatch,
            SuperSupreme
        };
        #endregion

        #region FIELDS

        private int _pizzaID;
        private string _size;
        private string _crust;
        private bool _isSpecialty;
        private Nullable<SpecialtyName> _specialtyName;
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

        public Nullable<SpecialtyName> PizzaSpecialtyName
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

        #region METHODS

        // build out string for pizza
        //
        //TODO: Velis - format prices to align in pizza listbox
        //
        public string FullPizzaDescription()
        {
            string fullPizzaDescription;
            if (_isSpecialty)
            {
                fullPizzaDescription =
                    _quantity.ToString().PadLeft(5) + "\t" +
                    _size.ToString().PadRight(10) + "\t" +
                    _crust.ToString().PadRight(10) + "\t" +
                    "Specialty Pizza".PadRight(10) + "\t" +
                    _pizzaPrice.ToString("C").PadLeft(10) + "\t" +
                    _specialtyName.ToString();

            }
            else
            {
                string pizzaToppings = string.Join(", ", _pizzaToppings.ToArray());

                fullPizzaDescription =
                    _quantity.ToString().PadLeft(5) + "\t" +
                    _size.ToString().PadRight(10) + "\t" +
                    _crust.ToString().PadRight(10) + "\t" +
                    "Toppings Pizza".PadRight(10) + "\t" +
                    _pizzaPrice.ToString("C").PadLeft(10) + "\t" +
                    pizzaToppings.ToString();
            }
            return (fullPizzaDescription);
        }

        //HACK: Velis - to get the full pizza description into the listbox
        public override string ToString()
        {
            return (FullPizzaDescription());
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
