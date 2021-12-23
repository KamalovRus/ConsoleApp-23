using System;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var factorial = await FactorialAsync(number);
            Console.WriteLine($"Factorial of {number}: {factorial}");
            Console.WriteLine("Enter any key to exit.");
            Console.ReadLine();
        }

        private static Task<int> FactorialAsync(int n)
        {
            return Task.Run(() => Calc(n));

            int Calc(int i)
            {
                if (i == 0)
                {
                    return 1;
                }
                if (i == 1)
                {
                    return 1;
                }

                return i * Calc(i - 1);
            }
        }
    }
}

