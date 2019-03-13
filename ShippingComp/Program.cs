using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingComp
{
    class Program
    {
        static void Main(string[] args)
        {

            OvernightPackage onpackage = new OvernightPackage(8.5M, "Tayfun Adakoğlu", "Süleyman Demirel", "yuh Avenue,dormitory", "K Avenue, VİLLA 22", "DENİZLİ", "İSTANBUL", "Aegean", "The Marmora", 20000, 34000, 5.5M, 2M); // creating new instances
            TwoDayPackage tdpackage = new TwoDayPackage(2M, "Tayfun Adakoğlu", "Süleyman Demirel", "B Avenue,X APART", "K Avenue, VİLLA 5", "DENİZLİ", "İSTANBUL", "Aegean", "The Marmora", 20000, 34000, 5.5M, 2M); // creating new instances
            Console.WriteLine(onpackage.CalculateCost()); // funcion tests
            Console.WriteLine(tdpackage.CalculateCost()); // funcion tests

            //ALSO
            Package[] pack = new Package[2];
            pack[0] = onpackage; // assigning the array of base class
            pack[1] = tdpackage; // assigning the array of base class
            decimal totalshipping = 0;
            for (int i = 0; i < pack.Length; i++)
            {
                
                if (pack[i] is OvernightPackage)
                {
                    Console.WriteLine("Over night package NO: {0}", i+1); // showing package no and other infos.
                    Console.WriteLine("Addresses: " + ((OvernightPackage)pack[i]).Addresssender + ((OvernightPackage)pack[i]).Addressrecipient);
                    Console.WriteLine("Shipping Cost :" + pack[i].CalculateCost());
                    totalshipping += pack[i].CalculateCost(); // calculating the total costs
                }
                else if (pack[i] is TwoDayPackage)
                {
                    Console.WriteLine("Two day package NO: {0}", i+1); // showing package no and other infos.
                    Console.WriteLine("Addresses: " + ((TwoDayPackage)pack[i]).Addresssender + ((TwoDayPackage)pack[i]).Addressrecipient);
                    Console.WriteLine("Shipping Cost :" + pack[i].CalculateCost());
                    totalshipping += pack[i].CalculateCost();  // calculating the total costs
                }
                Console.WriteLine();
                Console.WriteLine("Total shipping cost:" + totalshipping); //showing total cost
                Console.WriteLine();
               
            }

            Console.ReadKey();


            
        }
    }
}
