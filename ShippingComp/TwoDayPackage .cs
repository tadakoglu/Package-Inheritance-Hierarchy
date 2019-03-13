using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingComp
{
    class TwoDayPackage : Package
    {
    private decimal flatfee;
    public decimal Flatfee
    //all properties for keeping the limits of fields.
    {
        get { return flatfee; }
        set { flatfee = value; }
    }
        //when each twodaypackage objects is created, an instance of base class is created with(:base(args) keywords),gets some args with constructor args. 
    public TwoDayPackage(decimal flatfee,string namesender,string namerecipient,string addresssender,string addressrecipient,string citysender,string cityrecipient,string statesender,string staterecipient,int zipcodesender,int zipcoderecipient,decimal weight,decimal costperounce) : base(namesender,namerecipient,addresssender,addressrecipient,citysender,cityrecipient,statesender,staterecipient,zipcodesender,zipcoderecipient,weight,costperounce)
    {
        this.flatfee = flatfee;
    }
    override public decimal CalculateCost()
{
 	 return base.CalculateCost() + this.flatfee;
}

    
    }
}
