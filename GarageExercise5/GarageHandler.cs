using System;
using System.Collections.Generic;
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
            
            var builder = new StringBuilder();
            UI<string>.Print("Vehicles Parked\n______________________\n");
            foreach (var v in garage)
            {
                //behöver använda interface som för drawable i game för att slippa att overrida ToString i alla vehicle klasser?
                if (v != null)
                {
                    UI<Vehicle>.Print(v); //ToDo lägg till IUI istället
                    UI<string>.Print("-------------------\n");
                }
            }

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
