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
        private byte _quantity = 1;
        

        //private List<PizzaTopping> _pizzaToppings = new List<PizzaTopping>();
        #endregion

        #region PROPERTIES
        

        public  int PizzaID
        {
            get { return _pizzaID; }
            set { _pizzaID = value; }
        }
      

        public string Size
        {
            get { return _size; }
            set { string _size = value; }
        }

               
        public string  Crust
        {
            get { return _crust; }
            set { _crust = value; }
        }
        public  bool isSpecialty;
                       
        #endregion

        #region CONSTUCTORS
        public Pizza()
        {

        }
        //public  Pizza (bool isSpecialty)
        //{

        //}

        #endregion
    }}
