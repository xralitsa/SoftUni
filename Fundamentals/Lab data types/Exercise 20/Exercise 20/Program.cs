using System;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsQuantity = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string kegMaxVolume = null;

            for (int i = 1; i <= kegsQuantity; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * (double)height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    kegMaxVolume = model;
                }

            }

            Console.WriteLine(kegMaxVolume);
        }
    }
}
