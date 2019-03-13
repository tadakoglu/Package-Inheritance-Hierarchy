using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingComp 
{
    class OvernightPackage : Package
    {
        private decimal feeperounce;
        //all properties for keeping the limits of fields.
        public decimal Feeperounce
        {
            get { return feeperounce; }
            set { feeperounce = value; }
        }
        //when each twodaypackage objects is created, an instance of base class is created with(:base(args) keywords),gets some args with constructor args. 
        public OvernightPackage(decimal feeperounce, string namesender, string namerecipient, string addresssender, string addressrecipient, string citysender, string cityrecipient, string statesender, string staterecipient, int zipcodesender, int zipcoderecipient, decimal weight, decimal costperounce)
            : base(namesender, namerecipient, addresssender, addressrecipient, citysender, cityrecipient, statesender, staterecipient, zipcodesender, zipcoderecipient, weight, costperounce)
        {
            this.feeperounce = feeperounce;
        }
        public override decimal CalculateCost()
{
 	 return Weight *(feeperounce+ Costperounce);
}
       
    }
}
