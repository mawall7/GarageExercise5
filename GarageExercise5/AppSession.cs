using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    internal class AppSession
    {
        private GarageHandler handler { get; set; }
        public void Run()
        {
            Initialize();
            Session();
        }

        private void Initialize()
            {
                handler = new GarageHandler();
                handler.CreateGarage(20);
                handler.Addnew(new Buss(Vehicle.VehicleType.Buss, "ABC123", 3, 1, 40));
                handler.Addnew(new Car(Vehicle.VehicleType.Car, "GDD125", 3, 2, Car.CarModel.Cabriolet));
                handler.ListV();
                
            }
            public void Session()
            {
                bool SessionActive = true;
                do
                {
                    PrintMenu();
                    GetInput();

                } while (SessionActive);

            }

            public static void PrintMenu()
            {
                UI<Vehicle>.PrintMenu();
            }

            private bool UnPark(string x) => handler.TakeOut(x);
            
            
        //private bool UnPark(string x) 
        //{
        //    return handler.TakeOut(x);
        //}

        public void GetInput()
        {
                var keyPressed = UI<Vehicle>.GetKey().ToString();

                switch (keyPressed)
                {
                    
                    
                    case "D2":
                        Console.WriteLine("Write RegNr to Unpark");
                        var k = Console.ReadLine();
                        
                    
                    if (UnPark(k))
                    {
                        Console.WriteLine("vehicle removed");
                    }
                    else Console.WriteLine("vehicle doesnt exist");

                    break;

                    case "D3":
                        ListVehicles();
                        break;
                    case "2":
                        Environment.Exit(1);
                        break;

                    default:
                        break;
                }
           

        }

        private void ListVehicles()
        {
            handler.ListV();
        }
    }
   
}
