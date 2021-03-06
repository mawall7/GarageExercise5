using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    internal class AppSession
    {
        private GarageHandler handler { get; set; }

        private bool SessionActive = true;
        public void Run()
        {
            Initialize();
            Session();
        }

        private void Initialize()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            handler = new GarageHandler();
            handler.CreateGarage(20);
            handler.Addnew(new Buss(Vehicle.VehicleType.Buss, "ABC123", 3, 1, 40), 1);
            handler.Addnew(new Car(Vehicle.VehicleType.Car, "GDD125", 3, 2, Car.CarModel.Cabriolet), 2);
            handler.ListV();
            

        }
        public void Session()
        {
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
                case "D0":
                    CreateNewGarage();
                    break;
                    

                case "D1":
                    
                    AddNewVehicle();
                    break;

                case "D2":
                    Console.WriteLine("Write RegNr to Unpark");
                    var k = Console.ReadLine();


                    if (UnPark(k.ToUpper()) == true)
                    {
                        Console.WriteLine("vehicle removed");
                    }
                    else Console.WriteLine("vehicle doesn't exist");
                    
                    break;

                case "D3":
                    ListVehicles();
                    break;
                case "Q":
                    SessionActive = false;
                    //Environment.Exit(0);
                    break;

                default:
                    break;
            }

        }

        private void CreateNewGarage()
        {
            UI<string>.Print("Enter Size, Nbr of spots"); //ToDo validation
            var key1 = UI<string>.GetInput(); // ToDo change to ReadLine();
            UI<string>.Print("Park Vehicles from start? y/n");
            var key2 = UI<string>.GetKey();
            switch (key2)
            {
                case ConsoleKey.N:
                    handler.CreateGarage(int.Parse(key1));
                    break;
                case ConsoleKey.Y:
                    handler.CreateGarage(int.Parse(key1));
                    UI<string>.Print("How many vehicles?");
                    var key3 = int.Parse(UI<string>.GetInput());
                    for (int i = 0; i < key3; i++)
                    {
                        AddNewVehicle();
                    }
                    break;
                  
                    

            }
            
        }

        private void AddNewVehicle()
        {
          
            UI<String>.Print("Input TypeOfVehicle :\nCar = C, Bus = B, M = Motorcycle, J = Jeep\n");
            var key = UI<Vehicle>.GetKey();
            var dict = new Dictionary<ConsoleKey, Action>()
            {
                {ConsoleKey.J, CreateJeep},
                {ConsoleKey.B, CreateBuss },
                {ConsoleKey.M, CreateMotorcycle },
                {ConsoleKey.C, CreateCar },
               
            };
        
            if (dict.ContainsKey(key))
            {
                var method = dict[key];
                method?.Invoke();
            }
            
            
        }


        private void CreateCar() 
        {
            try
            {

                Car car = new Car(Vehicle.VehicleType.Car, ReadregNr() , ReadSize(), ReadSpotNr(), ChooseModel());
                handler.Addnew(car, car.GetSpot());
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        private int ReadSize()
        {
            UI<string>.Print("Size : ");
            return int.Parse(Console.ReadLine());
        }


        //private void GeneralCreate<T>(T c)  ToDo DI
        //{
        //    string r =  ReadregNr();
        //    int s = ReadSize(); 

        //    if(c is Motorcycle) {  } 

        //}

        private void CreateMotorcycle()
        {
            try
            {

                Motorcycle motorcycle = new Motorcycle(Vehicle.VehicleType.MotorCycle, ReadregNr(), ReadSize(), ReadSpotNr(), Choosecylinders());
                handler.Addnew(motorcycle, motorcycle.GetSpot());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        private void CreateJeep()
        {
            try
            {

                Jeep jeep = new Jeep(Vehicle.VehicleType.Jeep, ReadregNr(), ReadSize(), ReadSpotNr(), ReadHP());
                handler.Addnew(jeep, jeep.GetSpot());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        private void CreateBuss()
        {
            try
            {

                Buss buss = new Buss(Vehicle.VehicleType.Buss, ReadregNr(), ReadSize(), ReadSpotNr(), ReadPassengrs());
                handler.Addnew(buss, buss.GetSpot());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

        private double ReadHP()
        {
            UI<string>.Print("Nr Of HosePowers : ");
            return int.Parse(Console.ReadLine());
        }

        private int Choosecylinders()
        {
            UI<string>.Print("Nr Of Cylinders : ");
            return int.Parse(Console.ReadLine());

        }

        private string ReadregNr()
        {
            UI<string>.Print("RegNr:");
            return Console.ReadLine().ToUpper();
        } 

        private int ReadSpotNr()
        {
            UI<string>.Print("SpotNr:");
            return int.Parse(Console.ReadLine());
        }

        private int ReadPassengrs()
        {
            UI<string>.Print("NrPassengers:");
            return int.Parse(Console.ReadLine());
        }
      
        private Car.CarModel ChooseModel()
        {
            Console.WriteLine("Choose carmodel\n 1 = Combi\n 2= Sonnet\n 3 = Cabriolet\n");
            Car.CarModel model;
            string key;
            int intkey;
            do
            {
                key = UI<Vehicle>.GetKey().ToString();
                char mykey = key[1];
                intkey = int.Parse(mykey.ToString()) - 1;

                if (intkey>=1 || intkey <= 3)
                { 
                    model = (Car.CarModel)intkey;
                    break;
                    
                }
                else 
                   Console.WriteLine("Out of range, please enter a valid number between 1-3");
                 
            } while (intkey < 1 || intkey > 3);

            return (Car.CarModel)intkey;
            
        }

       
        private void ListVehicles()
        {
            UI<Vehicle>.Clear();
            handler.ListV();
        }
    }
   
}


