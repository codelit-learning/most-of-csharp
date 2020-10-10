using System;

namespace MostOfCSharp.Chapters.Oops.ExtendingAClass
{
    class Driver
    {
        public static void run()
        {
            SuperPerson jon = new SuperPerson("Jon", 23, "fly");
            Console.WriteLine(jon);
        }
    }
}