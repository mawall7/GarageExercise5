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


        public bool AddVehicle(Vehicle v, int x)
        {

            if (x < GarageLength && SearchVehicle(x) == false)
            {
                GarageOfVehicles[x-1] = v;
                return true;
            }
            else 
                return false;
            
            //GarageOfVehicles.Append(v);
        }

        public int GarageLength => GarageOfVehicles.Length; 

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

        public bool SearchVehicle(Vehicle v)
        {
            bool value = GarageOfVehicles.Contains(v)? true : false;
            return value;
        }

        public bool SearchVehicle(int x)
        {
            bool value = false;

            if (x < GarageOfVehicles.Length)
                value = GarageOfVehicles[x] != null ? true : false;  
             
            return value;

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
