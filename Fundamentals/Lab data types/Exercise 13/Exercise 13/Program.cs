﻿using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(((firstNumber + secondNumber) / thirdNumber) * forthNumber);
        }
    }
}
