using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int populationCount = int.Parse(Console.ReadLine());
            int townArea = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {populationCount} and area {townArea} square km.");
        }
    }
}
