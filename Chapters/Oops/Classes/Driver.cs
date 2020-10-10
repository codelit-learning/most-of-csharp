using System;

namespace MostOfCSharp.Chapters.Oops.Classes
{
    class Driver
    {
        public static void run()
        {
            Person rajat = new Person("Rajat", 32);
            Console.WriteLine(rajat);

            // changing properties
            rajat.Name = "Rajet";
            Console.WriteLine(rajat);
        }
    }
}