﻿using System;

namespace _02._Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int lastDigit = input%10;
            string name = "";
            switch (lastDigit)
            {
                case 0: name="zero"; break;
                case 1: name ="one"; break;
                case 2: name="two"; break;
                case 3: name="three"; break;
                case 4: name="four"; break;
                case 5: name="five"; break;
                case 6: name="six"; break;
                case 7: name="seven"; break;
                case 8: name="eight"; break;
                case 9: name="nin"; break;
            }
            Console.WriteLine(name);
        }
    }
}