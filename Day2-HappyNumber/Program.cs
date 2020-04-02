using System;
using System.Collections.Generic;

namespace Day2_HappyNumber
{

    class Program
    {
        static void Main(string[] args)
        {

            Day2 day2 = new Day2();

            Console.WriteLine(day2.IsHappy(19));
            Console.WriteLine(day2.IsHappy(2));
            Console.WriteLine(day2.IsHappy(7));
            Console.WriteLine(day2.IsHappy(11));

        }
    }
}
