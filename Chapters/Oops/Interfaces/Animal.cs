using System;

namespace MostOfCSharp.Chapters.Oops.Interfaces
{
    class Animal : Mobility
    {
        public string Species {get; set;}

        public Animal (string Species)
        {
            this.Species = Species;
        }

        public void walk()
        {
            Console.WriteLine("I walked");
        }

        public void run()
        {
            Console.WriteLine("I ran");
        }
    }
}