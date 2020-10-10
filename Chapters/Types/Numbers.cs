using System;

namespace MostOfCSharp.Chapters.Types
{
    class Numbers
    {
        public static void run()
        {
            int dec = 2;
            Console.WriteLine(dec);

            Console.WriteLine("{0}, {1}", int.MinValue, int.MaxValue);
            // More integral types here
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            int hex = 0x02;
            Console.WriteLine(hex);

            int bin = 0b_10;
            Console.WriteLine(bin);

            // floating-point types
            float flo = 45.123f;
            double dou = 45.123;
            decimal deci = 45.123m; // cannot be mixed with floats and doubles in calculations
            Console.WriteLine("{0}, {1}, {2}", flo, dou, deci);

            // precision and range of decimal vs double
            Console.WriteLine("{0}", 1.0d/3.0d);
            Console.WriteLine("{0}", 1.0m/3.0m);
        }
    }
}