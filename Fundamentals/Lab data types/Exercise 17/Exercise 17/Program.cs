using System;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string lineOfSymbols = null;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                char symbol = (char)i;
                lineOfSymbols += symbol;
                lineOfSymbols += ' ';
            }

            Console.WriteLine(lineOfSymbols);
        }
    }
}
