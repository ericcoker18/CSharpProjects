using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    class Car: Vehicle
    {
        string type { get; set; }
        int NumOfDoors { get; set; }

        public Car(string Type, int numOfDoors, int licenseNum, string Make, string Model, int Price) : base(licenseNum, Make, Model, Price)
        {
            type = Type;
            NumOfDoors = numOfDoors;

        }
        override public string VehicleInfo()
        {
            string Description = $"This vehicle description is {NumOfDoors}, {type}, {LicenseNum}, {Make}, {Model}, ${Price} ";
            return Description;



        }

    }
}
