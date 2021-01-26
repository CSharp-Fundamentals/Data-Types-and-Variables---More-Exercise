using System;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                long a = long.Parse(tokens[0]);

                long b = long.Parse(tokens[1]);

                long maxNumber = Math.Max(a, b);
                long sum = 0;

                while (Math.Abs(maxNumber) > 0)
                {
                    sum += maxNumber % 10;
                    maxNumber /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }

        }
    }
}