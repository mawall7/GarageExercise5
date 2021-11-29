using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
