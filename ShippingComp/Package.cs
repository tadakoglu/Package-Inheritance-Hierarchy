using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingComp
{
    class Package
    {
        private string namesender, namerecipient;
        //all properties for keeping the limits of fields.
        public string Namerecipient
        {
            get { return namerecipient; }
            set { namerecipient = value; }
        }

        public string Namesender
        {
            get { return namesender; }
            set { namesender = value; }
        }
        private string addresssender, adressrecipient;

        public string Addressrecipient
        {
            get { return adressrecipient; }
            set { adressrecipient = value; }
        }

        public string Addresssender
        {
            get { return addresssender; }
            set { addresssender = value; }
        }
        private string citysender, cityrecipient;
        //all properties for keeping the limits of fields.
        public string Cityrecipient
        {
            get { return cityrecipient; }
            set { cityrecipient = value; }
        }

        public string Citysender
        {
            get { return citysender; }
            set { citysender = value; }
        }
        private string statesender, staterecipient;

        public string Staterecipient
        {
            get { return staterecipient; }
            set { staterecipient = value; }
        }

        public string Statesender
        {
            get { return statesender; }
            set { statesender = value; }
        }
        private int zipcodesender, zipcoderecipient;
        //all properties for keeping the limits of fields.
        public int Zipcoderecipient
        {
            get { return zipcoderecipient; }
            set { zipcoderecipient = value; }
        }

        public int Zipcodesender
        {
            get { return zipcodesender; }
            set { zipcodesender = value; }
        }
       //all properties for keeping the limits of fields.
       private decimal weight; 
       private decimal costperounce;
       public decimal Weight
       {
           get{ return weight; }
           set{ if( value> 0)
               weight = value;
                else
               Console.WriteLine("weight cannot be negative");  // control
           }
       }
        public decimal Costperounce
       {
           get{ return costperounce; }
           set{ if( value > 0)
               costperounce = value;
                else
               Console.WriteLine("cost per ounce cannot be negative"); // control
           }
        }

        virtual public decimal CalculateCost()
        {
            return weight * costperounce; // calculating cost..
        }


    public Package(string namesender,  // constructor arguments
        string namerecipient,string addresssender,
        string addressrecipient,string citysender,
        string cityrecipient,string statesender,string staterecipient,
        int zipcodesender, int zipcoderecipient,decimal weight,
        decimal costperounce)
    {
        Namesender = namesender; // assigning incoming values to fields through properties
        Namerecipient = namerecipient;
        Addresssender = addresssender;
        Addressrecipient = addressrecipient;
        Citysender = citysender;
        Cityrecipient = cityrecipient;
        Statesender = statesender;
        Staterecipient = staterecipient;
        Zipcodesender = zipcodesender;
        Zipcoderecipient = zipcoderecipient;
        Weight = weight;
        Costperounce = costperounce;
        
    }
    


        


    }
}
