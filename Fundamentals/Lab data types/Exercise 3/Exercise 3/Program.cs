using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            double usDollars = britishPounds * 1.31d;
            Console.WriteLine($"{usDollars:f3}");
        }
    }
}
