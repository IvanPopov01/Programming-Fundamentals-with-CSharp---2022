using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] j = { 1, 2, 3 };

            for (int i = 0; i < 3; i++)
            {
                int x = int.Parse(Console.ReadLine());
                j[i] = x;
            }

            Array.Sort(j);
            Array.Reverse(j);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(j[i]);
            }
        }
    }
}
