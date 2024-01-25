using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine("{0:0.00}", kilometers);
        }
    }
}
