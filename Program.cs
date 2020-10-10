// using MostOfCSharp.Chapters.Types;
using MostOfCSharp.Chapters.Miscellaneous;
using System.Threading.Tasks;

namespace MostOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Tasks.run();
            t.Wait();
        }
    }
}
