// Vehicle_rental__management_Assign3;
namespace Vehicle_rental__management_Assign3;
class Program
{
    
    static void Main(string[] args)
    {
        Car car = new Car("Civic", "Honda", 2018, 40.5m, 4, "Gasoline", "Automatic", true);
         Truck truck = new Truck("F-150", "Ford", 2022, 60.0m, 1000, "Diesel", true);
        Motorcycle motorcycle = new Motorcycle("Ninja 400", "Kawasaki", 2020, 20.0m, 399, "Gasoline", false);
        RentalAgency agency = new RentalAgency(10);
        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);
        agency.RentVehicle(car);
        motorcycle.DisplayDetails();
    }
}
    