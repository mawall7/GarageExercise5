using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    class Car: Vehicle
    {
        private CarModel Model;

        public enum CarModel
        {
            Combi,
            Sonnet,
            Cabriolet
        }
        public Car(VehicleType type, string regNr, int size, int spot, CarModel model) : base(type, regNr, size, spot)
        {
            Model = model;
        }

        public override string ToString()
        {
            return $"Vehicle:\nRegNr:{RegNr}\nVType:{Type}\nSize:{Size}\nSpot:{GetSpot()}\n CarModel:{Model}";
        }




    }
}
