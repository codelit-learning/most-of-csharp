using System;

namespace MostOfCSharp.Chapters.Types
{
    class Bools
    {
        public static void run()
        {
            bool condition = true;
            Console.WriteLine(condition ? "It's true." : "It's false.");

            if (condition) Console.WriteLine("Condition was true.");

            // boolean logical operators
            bool extraCondition = condition & true; // Can also use | for OR
            Console.WriteLine(extraCondition);

            // operator precedence
            bool opPrec = true | true & false;
            bool opPrec2 = (true | true) & false;
            Console.WriteLine("{0}, {1}", opPrec, opPrec2);
        }
    }
}