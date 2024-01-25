using System;

namespace Exercise_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sumNumbers = 0m;
             
            for (int i = 1; i <= n; i++)
            {
                decimal newNumber = decimal.Parse(Console.ReadLine());
                sumNumbers += newNumber;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
