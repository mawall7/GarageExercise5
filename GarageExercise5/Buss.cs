using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    public class Buss :Vehicle
    {
        public int NrPassengers { get; set; }
        public Buss(VehicleType type, string regNr, int size, int spot, int nrPassengers) : base(type, regNr, size, spot)
        {
            NrPassengers = nrPassengers;
        }

        public override string ToString()
        {
            return $"Vehicle:\nRegNr:{RegNr}\nVType:{Type}\nSize:{Size}\nSpot:{GetSpot()}\nNPassengers:{NrPassengers}";
        }



    }
}
