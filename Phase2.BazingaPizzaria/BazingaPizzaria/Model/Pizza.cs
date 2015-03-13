using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Pizza
    {
        #region FIELDS
    
        private int _pizzaID;
        private string _size;
        private string _crust;
        private bool _isSpecialty;
        private enum _SpecialtyName
        { 
            Ultimate_Cheese,
            Piled_High_Pepperoni,
            Mounds_of_Meat,
            Veggie_Patch,
            Super_Supreme,   
        };
        private byte _quantity = 1;
        public enum _topping
        {
            Pepperoni,
            Italian_Sausage,
            Ham,
            Mushrooms,
            Olives,
            Green_Peppers,

        };

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
                       
        #endregion
    }}
