using System;

namespace GarageExercise5
{
    class Program
    {
        public static GarageHandler handler;
        static void Main(string[] args)
        {
            AppSession session = new AppSession();
            session.Run();
            Console.WriteLine("Session ended! You are using GarageApplication v.1.");
            Console.ReadLine();


        }

       

        
            


    }
}
