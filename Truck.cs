using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_rental__management_Assign3
{
    // defining the truck class which inherits the vehicle class
    public class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }
        //constructor of the truck class and inherits parameters from the base class
        public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
                : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }
       //calls the base class to display vehicle details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Truck Type: {TruckType}");
            Console.WriteLine($"Four Wheel Drive: {FourWheelDrive}");
        }
    }
}