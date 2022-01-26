using System;
using System.Text;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] simbols = { " ", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            StringBuilder messages = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                messages.Append(simbols[number[0] - '0'][number.Length - 1]);
            }


            Console.WriteLine(messages.ToString());
        }
    }
}
