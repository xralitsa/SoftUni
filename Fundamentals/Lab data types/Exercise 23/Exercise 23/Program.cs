using System;

namespace Exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            long bestSnowballValue = 0;

            for (int i = 0; i < n; i++)
            {
                 int snowballSnow = int.Parse(Console.ReadLine());
                 int snowballTime = int.Parse(Console.ReadLine());
                 int snowballQuality = int.Parse(Console.ReadLine());


                 long newSnowballValue = (long)Math.Pow(snowballSnow / snowballTime, snowballQuality);

                if (newSnowballValue > bestSnowballValue)
                {
                    bestSnowballValue = newSnowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
