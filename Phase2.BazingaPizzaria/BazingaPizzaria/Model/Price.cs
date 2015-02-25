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
        private Double _beverageSm;
        private Double _beverageMd;
        private Double _beverageLg;

        #endregion

        #region Properties
        public Double BeverageSm
        {
            get { return _beverageSm; }
        }

        public Double BeverageMd
        {
            get { return _beverageMd; }
        }
        public Double BeverageLg
        {
            get { return _beverageLg; }
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
