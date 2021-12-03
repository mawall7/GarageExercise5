using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageExercise5
{
    public class GarageHandler
    {
        private Garage<Vehicle> garage;
        public void CreateGarage(int Nspots)
        {
            garage = new Garage<Vehicle>(Nspots);
        }

        public void ListV()
        {
            
            // ToDo builder = new StringBuilder();
            UI<string>.Print("Vehicles Parked\n______________________\n");
            var x = 0;
            foreach (var v in garage)
            {
                x = x+1;
               //ToDo behöver använda interface som för drawable i game 
                Console.Write(x.ToString() + ".");
                if (v != null)
                {

                    UI<string>.Print($"Regnr:{ v.RegNr} Type:{v.Type}\n");
                    //UI<string>.Print("-------------------\n");
                }
                else if (v == null) 
                    UI<string>.Print("empty\n");
            }

            PrintTypes();
            UI<string>.Print("______________________\n");

        }

        public void PrintTypes()
        {
           
            UI<string>.Print("\nNr Of each Type of Vehicle\n"); UI<string>.Print("______________________\n");

            UI<string>.Print($"Car:{garage.NrOfCars}\nMotorcycle:{garage.NrOfMotorCycles}\nBusses:{garage.NrOfBusses}\nBoats:{garage.NrOfBoats}\nJeeps:{garage.NrOfJeeps}\nAirplanes:{garage.NrOfAirplanes}\n\n");
            try
            {   foreach (var item in Enum.GetValues(typeof(Vehicle.VehicleType)))
                {
                    garage.Where(a => a?.Type == (Vehicle.VehicleType)item).ToList().ForEach(x => Console.WriteLine($"{(Vehicle.VehicleType)item}:\n{x}\n"));
                }

            }
            catch (Exception)
            {

                throw;
            }
                      
        }

        public  void Addnew(Vehicle v, int x)
        {
            string message = garage.AddVehicle(v, x) ? $"Vehicle {v.RegNr} parked at spot{v.GetSpot()}!\n" : "Vehicle could not be parked\n";
            
           UI<string>.Print(message);
        }


        public bool TakeOut(string regnr) //remove vehicle
        {
            var v = garage.SearchVehicle(regnr);

            return garage.EraseVehicle(v);
        }

       
    }
}
