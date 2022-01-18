using System;

namespace _6._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = input;
            int sum = 0;

            while (num > 0)
            {

                int n = num%10;
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                sum +=n;
                num = num/10;
            }
            if(sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
