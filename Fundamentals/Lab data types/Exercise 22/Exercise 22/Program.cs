using System;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int startValue = n;
            int y = int.Parse(Console.ReadLine());
            int targets = 0;

            while (n >= m)
            {

                n -= m;
                targets++;

                if (n == (int)Math.Ceiling((double)startValue * 50 / 100) && y != 0)
                {
                    n /= y;
                }

            }

            Console.WriteLine(n);
            Console.WriteLine(targets);

        }
    }
}
