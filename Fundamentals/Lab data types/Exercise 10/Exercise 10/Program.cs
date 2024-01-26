using System;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            bool result;
            result = Char.IsLower(firstInput);
            if (result == true)
            {
                Console.WriteLine("lower-case");
            }
            else 
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
