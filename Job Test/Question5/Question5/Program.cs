using System;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);
        }

        private static async Task<Tuple<float, int>> SomeCalculation(long v1, int v2, bool v3)
        {
            return Tuple.Create(1f, 2);
        }
    }
}
