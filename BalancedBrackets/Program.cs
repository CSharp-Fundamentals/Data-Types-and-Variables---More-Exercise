using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int open = 0;
            int close = 0;

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                if (text=="(")
                {
                    open++;
                }
                else if (text==")")
                {
                    close++;
                }
                if (open<close)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (open==close)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
