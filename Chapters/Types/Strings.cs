using System;

namespace MostOfCSharp.Chapters.Types
{
    class Strings
    {
        public static void run()
        {
            string a = "Hello";
            Console.WriteLine(a);

            char b = 'H';
            Console.WriteLine(b);

            Console.WriteLine(a[2]);

            // empty string
            string emptyString = String.Empty;
            Console.WriteLine(emptyString);

            // constant string
            const string constString = "Cannot move me";
            Console.WriteLine(constString);

            // string interpolation
            string greeting = $"{a}, World";
            Console.WriteLine(greeting);

            // string length
            Console.WriteLine(greeting.Length);

            // string from character array
            char[] nameChars = {'R', 'a', 'j', 'a', 't'};
            string name = new string(nameChars);
            Console.WriteLine(name);

            // immutability
            greeting += constString; // a new string object is created and assigned to greeting.

            // multiline strings (i.e. verbatim strings)
            string message = @"Hi Reader,
                This is a small letter from I to you.
                Take care.
                Love from India.";
            Console.WriteLine(message);

            // substring
            Console.WriteLine($"{name.Substring(0, 3)}");

            // searching
            int indexOfRaj = name.IndexOf("Raj");
            int indexOfJon = name.IndexOf("Jon");
            Console.WriteLine("{0}, {1}", indexOfRaj, indexOfJon);
            // there are other methods as well like String.Contains, String.StartsWith and String.EndsWith

            // splitting strings
            string[] greetingWords = greeting.Split(' ');
            Console.WriteLine(greetingWords[0]);

            // Comparing strings
            string message2 = @"Hi Reader,
                This is a small letter from I to you.
                Take care.
                Love from India.";
            Console.WriteLine(message2.Equals(message));
        }
    }
}