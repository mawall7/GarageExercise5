using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageExercise5
{
    public class Garage : IEnumerable
    {
        private int NParkingSlots;

        private List<Vehicle> GarageOfVehicles;

        public Garage(int spots)
        {
            GarageOfVehicles = new List<Vehicle>(spots);
            
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            foreach( Vehicle item in GarageOfVehicles)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddVehicle(Vehicle v)
        {
            GarageOfVehicles.Add(v);
        }

        public bool EraseVehicle(Vehicle ve)
        {
            Vehicle vOut = GarageOfVehicles.Where(v => v == ve).FirstOrDefault();
            if (vOut == null)
                return false;
            
            else return GarageOfVehicles.Remove(vOut);
        }

        public Vehicle SearchVehicle(string r) 
        {
            Vehicle vSearch = GarageOfVehicles.Where(v => v.RegNr == r).FirstOrDefault();
            if (vSearch != null)
            {
                return vSearch;
            }
            else return null;
                

        }
    }
}
