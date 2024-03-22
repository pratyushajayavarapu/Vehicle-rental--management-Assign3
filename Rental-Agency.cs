using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_rental__management_Assign3
{
    public class RentalAgency
    {
        private Vehicle[] Fleet { get; set; }
        public decimal TotalRevenue { get; private set; }

        public RentalAgency(int fleetSize)
        {
            Fleet = new Vehicle[fleetSize];
        }

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