using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static bool EnoughMoney(double money, double price)
        {
            if (price<=money)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double money = 0.0;

            while (command!="Start")
            {
                double coin = double.Parse(command);
                if (coin==0.1||coin==0.2||coin==0.5||coin==1||coin==2)
                {
                    money+=coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();

            }
            
            command = Console.ReadLine();
            while (command!="End")
            {
                string product = command;
                double price = 0.0;
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;

                        if (EnoughMoney(money, price))
                        {
                            money-=price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        price = 0.7;
                        if (EnoughMoney(money, price))
                        {
                            money-=price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        price = 1.5; if (EnoughMoney(money, price))
                        {
                            money-=price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        price = 0.8; if (EnoughMoney(money, price))
                        {
                            money-=price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        price = 1.0; if (EnoughMoney(money, price))
                        {
                            money-=price;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:F2}");
        }
    }
}
