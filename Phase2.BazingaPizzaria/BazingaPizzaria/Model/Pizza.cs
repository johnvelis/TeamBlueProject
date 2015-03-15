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

        public enum _topping
        {
            Pepperoni,
            ItalianSausage,
            Ham,
            Mushrooms,
            Olives,
            GreenPeppers,

        };
        #endregion
        #region FIELDS

        private int _pizzaID;
        private string _size;
        private string _crust;
        private bool _isSpecialty;
        private enum _SpecialtyName //Roxie does this need to public for your purposes?
        { 
            UltimateCheese,
            PiledHighPepperoni,
            MoundsofMeat,
            VeggiePatch,
            SuperSupreme,   
        };
        private byte _quantity = 1;
        

        private List<PizzaTopping> _pizzaToppings = new List<PizzaTopping>();
        #endregion

        #region PROPERTIES
        

        public  int PizzaID
        {
            get { return PizzaID; }
            set { PizzaID = value; }
        }
      

        public string Size
        {
            get { return Size; }
            set { string Size = value; }
        }

               
        public string  Crust
        {
            get { return Crust; }
            set { Crust = value; }
        }
        public  bool isSpecialty;
                       
        #endregion

        #region CONSTUCTORS
        public Pizza()
        {

        }
        public  Pizza (isSpecialty)
        {

        }

        #endregion
    }}
