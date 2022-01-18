using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";
            for (int i = userName.Length-1; i>=0; i--)
            {
                password+=(userName[i]);
            }
            int attempt = 1;
            while (attempt<=4)
            {
                string input = Console.ReadLine();

                if (password==input)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (attempt!=4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        attempt++;
                    }
                    else
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                }
            }
        }
    }
}
