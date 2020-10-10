using System;
using System.Threading.Tasks;
using System.Threading;

namespace MostOfCSharp.Chapters.Miscellaneous
{
    class Tasks
    {
        private static int LongRunningMethod()
        {
            int res = 0;
            int counter = 0;
            while (counter < 100)
            {
                counter++;
                res += counter;
                Thread.Sleep(1);
            }

            Console.WriteLine(res);
            return res;
        }

        public async static Task run()
        {
            int result = await Task.Run(() => LongRunningMethod());
            Console.WriteLine("Result: {0}", result);
        }
    }
}