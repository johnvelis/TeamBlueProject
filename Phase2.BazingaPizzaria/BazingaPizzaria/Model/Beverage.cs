using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazingaPizzaria.Model
{
    public class Beverage
    {
        #region ENUM

        public enum BevSize
        {
            Small,
            Medium,
            Large,
            XL
        }

        #endregion

        #region FIELDS
        private string _name;
        private BevSize _beverageSize;
        private int _quantity;
        private decimal _bevPrice;
        private decimal _basePrice;
        #endregion

        #region PROPERTIES
        public decimal BasePrice
        {
            get { return _basePrice; }
        }


        public decimal BevPrice
        {
            get { return _bevPrice; }
            set { _bevPrice = value; }
        }

        public string SizeName { get { return _beverageSize + " " + _name; } }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public BevSize BeverageSize
        {
            get { return _beverageSize; }
            set { _beverageSize = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        #endregion

        #region METHODS

        // build out string for beverage
        //
        //TODO: Velis - format prices to align in beverage listbox
        //
        public string FullBeverageDescription()
        {
            string fullBeverageDescription;
            fullBeverageDescription =
            _quantity.ToString().PadLeft(5) + "\t" +
            _beverageSize.ToString().PadRight(10) + "\t" +
            _name.ToString().PadRight(15) + "\t" +
            _bevPrice.ToString("C").PadLeft(15);

            return (fullBeverageDescription);
        }

        //HACK: Velis - to get the full berverage description into the listbo
        public override string ToString()
        {
            return (FullBeverageDescription());
        }

        #endregion

        #region CONSTRUCTORS

        public Beverage()
        {

        }

        public Beverage(string name, BevSize beverageSize, int quantity, decimal price)
        {
            _name = name;
            _beverageSize = beverageSize;
            _quantity = quantity;
            _bevPrice = price;
            _basePrice = price;
        }
        #endregion
    }
}
