using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    class Truck : Vehicle
    {
        string bedsize { get; set; }

        public Truck(string BedSize, int licenseNum, string Make, string Model, int Price) : base(licenseNum, Make, Model, Price)
        {
            bedsize = BedSize;
        }

        override public string VehicleInfo()
        {
            string Description = $"This vehicle description is {bedsize}, {LicenseNum}, {Make}, {Model}, ${Price} ";
            return Description;



        }
    }
}
