using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    public class GarageHandler
    {
        private Garage garage;
        public void CreateGarage(int Nspots)
        {
            garage = new Garage(Nspots);
        }

        public void ListV()
        {

            foreach(Vehicle v in garage)
            {
                UI<Vehicle>.Print(v); //ToDo lägg till IUI istället
                //Console.WriteLine($"Vehicle:\nRegNr:{v.RegNr}\nVType:{v.Type}\nSize:{v.Size}\nSpot:{v.GetSpot()}");
            }

        }

        public void Addnew(Vehicle v)
        {
            garage.AddVehicle(v);

        }
    }
}
