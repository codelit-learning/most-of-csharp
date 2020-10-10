using System;

namespace MostOfCSharp.Chapters.Types
{
    enum Categories
    {
        Parts,
        Accessories
    };

    class Tuples
    {
        public static void run()
        {
            (string Name, double Price, Categories Category) Product =
                ("Machine Oil", 23.99, Categories.Accessories);
            Console.WriteLine($"{Product.Name}: {Product.Price}, {Product.Category}");
        }
    }
}