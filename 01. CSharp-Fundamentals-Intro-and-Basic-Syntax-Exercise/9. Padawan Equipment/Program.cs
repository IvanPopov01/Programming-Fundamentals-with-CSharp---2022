using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfmoney = double.Parse(Console.ReadLine());
            int counOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double x = counOfStudents*priceOfRobe;
            double a = ((priceOfBelt*counOfStudents)-(counOfStudents/6*priceOfBelt));
            double b = (priceOfLightsaber*(Math.Ceiling(counOfStudents*0.1)+counOfStudents));

            double totalMony = x+a+b;

            if (totalMony<=amountOfmoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMony:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {(totalMony-amountOfmoney):f2}lv more.");
            }
        }
    }
}
