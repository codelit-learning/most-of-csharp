using System;

namespace MostOfCSharp.Chapters.Miscellaneous
{
    class Arrays
    {
        public static void run()
        {
            // single dimensional array
            int[] nums = new int[2];
            nums[1] = 1;

            string[] students = new string[]{"rajat", "jon"};

            // multi-dimensional array
            char[,] maps = new char[2, 2];
            maps[0, 0] = 'b';

            // jagged array - array of arrays
            int[][] marks = new int[6][];
            marks[0] = new int[]{80, 23, 38, 46, 58};

            Console.WriteLine($"Student's marks in Maths: {marks[0][0]}");
        }
    }
}