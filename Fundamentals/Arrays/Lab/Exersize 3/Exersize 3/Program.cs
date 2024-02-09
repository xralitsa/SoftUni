using System;
using System.Linq;

namespace Exersize_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();



            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " => " + (int)Math.Round(arr[i],MidpointRounding.AwayFromZero));
            }
        }
    }
}
