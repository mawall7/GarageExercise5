using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    public abstract class Vehicle : IVehicle
    {
        public VehicleType Type { get; set; }
        public string RegNr { get; set; }
        public int Size { get; set; }

        private int spot; 

        public enum VehicleType
        {
            MotorCycle,
            Car,
            Jeep,
            Buss
        }

        public Vehicle(VehicleType type, string regNr, int size, int spot)
        {
            Type = type;
            RegNr = regNr;
            Size = size;
            this.spot = spot;
        }

        public int GetSpot() 
        {
            return spot;
        
        }

        public override string ToString()
        {
            return $"Vehicle:\nRegNr:{RegNr}\nVType:{Type}\nSize:{Size}\nSpot:{spot}";
        }

    }
}
