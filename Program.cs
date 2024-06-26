﻿// Vehicle_rental__management_Assign3;
namespace Vehicle_rental__management_Assign3;
// Define the Program class.
class Program
{
    //The main method, where the program starts execution.   
    static void Main(string[] args)
    {
        // Creating instances of different types of vehicles
        Car car = new Car("Civic", "Honda", 2018, 40.5m, 4, "Gasoline", "Automatic", true);
         Truck truck = new Truck("F-150", "Ford", 2022, 60.0m, 1000, "Diesel", true);
        Motorcycle motorcycle = new Motorcycle("Ninja 400", "Kawasaki", 2020, 20.0m, 399, "Gasoline", false);

        // Create an instance of RentalAgency
        RentalAgency agency = new RentalAgency(10);

        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);
        agency.RentVehicle(car);
        motorcycle.DisplayDetails();
    }
}
    