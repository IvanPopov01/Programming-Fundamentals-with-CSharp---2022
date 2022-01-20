using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardtPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashHeadsets = lostGames/2;
            int trashMouse = lostGames/3;
            int trashKeyboard = lostGames/6;
            int trashDisplay = lostGames/12;

            double expenses = (trashHeadsets*headsetPrice)+(trashMouse*mousePrice)+(trashKeyboard*keyboardtPrice)+(trashDisplay*displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
