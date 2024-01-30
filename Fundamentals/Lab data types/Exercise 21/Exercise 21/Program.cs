using System;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int spiceProductionPerDay = int.Parse(Console.ReadLine());
            int spiceReserve = 0;
            int workingDays = 0;
            
            while (spiceProductionPerDay >= 100)
            {
                spiceReserve = spiceReserve + spiceProductionPerDay - 26;
                workingDays++;
                spiceProductionPerDay -= 10;
            }

            spiceReserve -= 26;
            Console.WriteLine($"{workingDays}\n{spiceReserve}");

        }
    }
}
