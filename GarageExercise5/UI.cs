using System;
using System.Collections.Generic;
using System.Text;

namespace GarageExercise5
{
    static class UI<T> 
    {
        public static void Print(T s)
        {
            if(s!=null)
            Console.WriteLine(s);
        }

        public static void PrintMenu()
        {
           Console.WriteLine("1 = Park\n2 = Unpark\n3 = ListVehicles\nQ = Quit");
        }

        internal static ConsoleKey GetKey()
            {
                return Console.ReadKey(intercept : true).Key;
            }

        internal static void Clear()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }

    }
}
