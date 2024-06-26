﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_rental__management_Assign3
{
    //defining motorcycle class which inherits from vehicle
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }
        // constructor for the motor cycle class
        public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
            : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }
        // to display vehicle details
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Has Fairing: {HasFairing}");
        }
    }
}