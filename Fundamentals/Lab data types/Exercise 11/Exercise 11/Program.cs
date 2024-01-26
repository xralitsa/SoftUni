using System;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Length: ");

            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");

            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");

            double heigth = double.Parse(Console.ReadLine());

            double volumePyramide = (length + width + heigth) / 3;

            Console.WriteLine($"Pyramid Volume: {volumePyramide:f2}");
        }
    }
}
