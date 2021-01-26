using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string sentence = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                sentence += letter;
            }
            Console.WriteLine(sentence);
        }
    }
}
