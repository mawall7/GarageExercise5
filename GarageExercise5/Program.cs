using System;

namespace GarageExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new GarageHandler();
            handler.CreateGarage(20);
            handler.Addnew(new Buss(Vehicle.VehicleType.Buss, "ABC123", 3, 1, 40));
            handler.Addnew(new Car(Vehicle.VehicleType.Car, "GDD125", 3, 2, Car.CarModel.Cabriolet));
            handler.ListV();
        }
    }
}
