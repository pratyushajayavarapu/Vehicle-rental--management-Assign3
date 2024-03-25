using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_rental__management_Assign3
{
    //Class for Rental Agency
    public class RentalAgency

    {
        private Vehicle[] Fleet { get; set; }
        public decimal TotalRevenue { get; private set; }
        //Constructor to initialize the rental agency with fleet
        public RentalAgency(int fleetSize)
        {
            Fleet = new Vehicle[fleetSize];
        }
        //method to add vehicle
        public void AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == null)
                {
                    Fleet[i] = vehicle;
                    return;
                }
            }

            Console.WriteLine("The fleet is full.");
        }
        //method to remove the vehicle
        public void RemoveVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] != null && Fleet[i].GetType() == vehicle.GetType())
                {
                    Fleet[i] = null;
                    return;
                }
            }

            Console.WriteLine("The vehicle is not in the fleet.");
        }
        //Method to Rent a vehicle
        public void RentVehicle(Vehicle vehicle)
        {
            if (Fleet.Any(v => v == vehicle))
            {
                Console.WriteLine("Vehicle rented.");
                TotalRevenue += vehicle.RentalPrice;
            }
            else
            {
                Console.WriteLine("The vehicle is not in the fleet.");
            }
        }
    }
}