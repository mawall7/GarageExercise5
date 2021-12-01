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
            foreach (var v in garage)
            {
                
                //behöver använda interface som för drawable i game för att slippa att overrida ToString i alla vehicle klasser?
                     
                UI<Vehicle>.Print(v); //ToDo lägg till IUI istället
                
                //Console.WriteLine($"Vehicle:\nRegNr:{v.RegNr}\nVType:{v.Type}\nSize:{v.Size}\nSpot:{v.GetSpot()}");
            }

        }

        public void Addnew(Vehicle v, int x)
        {
            garage.AddVehicle(v, x);

        }

        public bool TakeOut(string regnr) //remove vehicle
        {
            var v = garage.SearchVehicle(regnr);

            return garage.EraseVehicle(v);
        }

        //public bool SearchVehicle(Garage garage)
        //{
        //    garage.FirstOrDefault()
        //}
    }
}
