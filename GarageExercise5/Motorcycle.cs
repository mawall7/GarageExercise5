using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    class Motorcycle : Vehicle
    {
        private int nrCylinders;
        public Motorcycle(VehicleType type, string regNr, int size, int spot, int nrCyl) : base(type, regNr, size, spot)
        {
            nrCylinders = nrCyl;
        }

        public override string ToString()
        {
            return $"Vehicle:\nRegNr:{RegNr}\nVType:{Type}\nSize:{Size}\nSpot:{GetSpot()}\nnrCylinders:{nrCylinders}";
        }
    }
}
