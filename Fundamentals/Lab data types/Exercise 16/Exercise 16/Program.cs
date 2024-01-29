using System;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int symbolToInt = (int)symbol;
                sum += symbolToInt;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
