using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int devisible, divider;

            for (devisible = 2; devisible <= range; devisible++)
            {
                bool check = true;
                for (divider = 2; divider < devisible; divider++)
                {
                    if (devisible % divider == 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", devisible, check.ToString().ToLower());
            }

        }
    }
}
