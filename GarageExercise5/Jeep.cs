using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    class Jeep: Vehicle
    {
        private double horsePowers;

        public Jeep(VehicleType type, string regNr, int size, int spot, double horsePow ) : base(type, regNr, size, spot)
        {
            horsePowers = horsePow;
        }

        public override string ToString()
        {
            return $"Vehicle:\nRegNr:{RegNr}\nVType:{Type}\nSize:{Size}\nSpot:{GetSpot()}\nHorsePowers:{horsePowers}";
        }
    }
}
