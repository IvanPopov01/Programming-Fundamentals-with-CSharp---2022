using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double singlePrice = 0.0;
            double discount = 0.0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday": singlePrice = 8.45; break;
                        case "Saturday": singlePrice = 9.80; break;
                        case "Sunday": singlePrice = 10.46; break;
                    }
                    if (countOfPeople>=30) { discount=singlePrice*countOfPeople*0.15; }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday": singlePrice = 10.90; break;
                        case "Saturday": singlePrice = 15.60; break;
                        case "Sunday": singlePrice = 16; break;
                    }
                    if (countOfPeople>=100) { discount=singlePrice*10; }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday": singlePrice = 15; break;
                        case "Saturday": singlePrice = 20; break;
                        case "Sunday": singlePrice = 22.5; break;
                    }
                    if (countOfPeople>=10 && countOfPeople<=20) { discount=singlePrice*countOfPeople*0.05; }
                    break;
            }
            double totalPrice = (countOfPeople*singlePrice)-discount;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
