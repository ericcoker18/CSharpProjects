using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Carlot1 = new CarLot("Honda");
            CarLot Carlot2 = new CarLot("Pollard Ford");
            Truck truck1 = new Truck("Large", 54847, "Ford", "Mustang", 30000);
            Truck truck2 = new Truck("Small", 48792, "Chevy", "Corvette", 60000);
            Car Car1 = new Car("Sedan", 4, 977468, "Dodge", "Dart", 50000);
            Car Car2 = new Car("Suv", 4, 484648, "Suburu", "CrossTrek", 27000);
            Carlot1.AddVehicle(truck1);
            Carlot1.AddVehicle(Car1);
            Carlot2.AddVehicle(truck2);
            Carlot2.AddVehicle(Car2);

            Carlot1.PrintVehicle();
            Carlot2.PrintVehicle();


        }
    }
}
