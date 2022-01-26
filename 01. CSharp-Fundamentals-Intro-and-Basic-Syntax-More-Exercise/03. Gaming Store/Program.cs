using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            bool isOk = true;
            double spend = 0.0;
            while ((command!="Game Time")&&isOk)
            {
                bool gameExists = true;
                double price = 0.0;
                switch (command)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;

                    default:
                        Console.WriteLine("Not Found");
                        gameExists = false;
                        break;
                }
                if ((balance>=price)&&gameExists)
                {
                    balance-=price;
                    spend+=price;
                    Console.WriteLine($"Bought {command}");
                }
                else if ((price>balance)&&(gameExists))
                {
                    Console.WriteLine("Too Expensive");
                }
                if (balance==0.0)
                {
                    Console.WriteLine("Out of money!");
                    isOk = false;
                }
                command = Console.ReadLine();
            }
            if ((command=="Game Time")&&isOk)
            {
                Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
