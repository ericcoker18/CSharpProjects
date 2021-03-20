using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    abstract class Vehicle
    {
        public int LicenseNum { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public Vehicle(int licenseNum, string make, string model, int price)
        {
            LicenseNum = licenseNum;
            Make = make;
            Model = model;
            Price = price;
        }
        virtual public string VehicleInfo()
        {
            string Description = $"This vehicle description is {LicenseNum}, {Make}, {Model}, ${Price} ";
            return Description;
        }



    }
}
