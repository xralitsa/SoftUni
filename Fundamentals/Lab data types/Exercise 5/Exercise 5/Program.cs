using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumOfNDigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumOfNDigits += digits % 10;
                    digits = digits / 10;
                }

                bool specialSum = (sumOfNDigits == 5) || (sumOfNDigits == 7) || (sumOfNDigits == 11);
                Console.WriteLine("{0} -> {1}", i, specialSum);
            }
        }
    }
}
