using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_rental__management_Assign3
{
    // Car class inherits from Vehicle class
    public class Car : Vehicle
    {
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }
        // Constructor for creating a Car object with specified properties.
        public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
            : base(model, manufacturer, year, rentalPrice)
        {
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }
        // Override method to display details of the car.
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Convertible: {Convertible}");
        }
    }
}