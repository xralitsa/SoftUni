using System;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumVolume = 0;

            for(int i = 1; i <= n; i++)
            {
                int additionalVolume = int.Parse(Console.ReadLine());

                if ((sumVolume + additionalVolume) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                else 
                {
                    sumVolume += additionalVolume;
                }
            }

            Console.WriteLine(sumVolume);
        }
    }
}
