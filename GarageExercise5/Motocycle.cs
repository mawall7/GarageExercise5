using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    class Motocycle : Vehicle
    {
        private int nrCylinders;
        public Motocycle(VehicleType type, string regNr, int size, int spot, int nrCyl) : base(type, regNr, size, spot)
        {
            nrCylinders = nrCyl;
        }
    }
}
