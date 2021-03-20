using System;
using System.Collections.Generic;
using System.Text;

namespace CarLot
{
    class CarLot
    {
        string Name { get; set; }
        List<Vehicle> Inventory;

        public CarLot (string name)
        {
            Name = name;
            Inventory = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            Inventory.Add(vehicle);

        }

        public void PrintVehicle()
        {
            foreach (Vehicle vehicle in Inventory)
            {
                Console.WriteLine(vehicle.VehicleInfo());
                Console.WriteLine(Name);
            }
        }

    }
}
