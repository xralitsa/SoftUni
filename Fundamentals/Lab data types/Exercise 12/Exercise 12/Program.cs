using System;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)

            {
                int sum = 0;
                int digit = i;

                while (digit > 0)

                {

                    sum += digit % 10;

                    digit = digit / 10;

                }

                bool isSpecialSum = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecialSum);
            }
        }
    }
}
