using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageExercise5
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int NParkingSlots;

        private Vehicle[] GarageOfVehicles;
        //private List<Vehicle> GarageOfVehicles;

        public Garage(int spots)
        {
            GarageOfVehicles = new Vehicle[spots];
            NParkingSlots = spots;
            // GarageOfVehicles = new List<Vehicle>(spots);

        }


        public void AddVehicle(Vehicle v, Index x)
        {
            GarageOfVehicles[x] = v;
            //GarageOfVehicles.Append(v);
        }

        public bool EraseVehicle(Vehicle v) 
        {
            int index;
            bool result = false;
            if (v != null)
            {

                index = Array.IndexOf(GarageOfVehicles, v); 
                GarageOfVehicles[index] = null;
                result = true;
            }
           
            return result;
                
            
        }





        //public bool EraseVehicle(Vehicle ve)
        //{
        //    int index;
        //    Vehicle vOut = GarageOfVehicles.Where(v => v == ve).FirstOrDefault();
        //    if (vOut == null)
        //        return false;
        //    else
        //        index = Array.IndexOf(GarageOfVehicles, ve);
        //    GarageOfVehicles[index] = null; return true;
        //    //else return GarageOfVehicles(vOut);
        //}

        public Vehicle SearchVehicle(string r)
        {
            Vehicle result;
            try
            {
            result = GarageOfVehicles.ToArray().Where(v => v?.RegNr == r).FirstOrDefault();

            }
            catch (Exception)
            {

                throw;
            }
            //Vehicle vSearch = GarageOfVehicles.Where(v => v.RegNr == r).FirstOrDefault();

            return result;

        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var item in GarageOfVehicles)
            {
                yield return item as T;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Vehicle this[int index] => GarageOfVehicles[index]; 

    }

}
