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
            try
            {
                garage.Where(a => a?.Type == Vehicle.VehicleType.Car).ToList().ForEach(x => Console.WriteLine($"Cars:\n{ x}"));


            }
            catch (Exception)
            {

                throw;
            }
            var NCars = 0;
            var MCycles = 0;
            var Airplanes = 0;
            
        }

        public void Addnew(Vehicle v, int x)
        {
            string message = garage.AddVehicle(v, x) ? "Vehicle Added" : "Vehicle could not be parked";
            
           UI<string>.Print(message);
        }


        public bool TakeOut(string regnr) //remove vehicle
        {
            var v = garage.SearchVehicle(regnr);

            return garage.EraseVehicle(v);
        }

       
    }
}
