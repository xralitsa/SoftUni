using System;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
           
            //simple solution:
            //if (peopleCount % capacity == 0)
            //{
            //    courses = peopleCount / capacity;
            //}

            //else 
            //{
            //   courses = peopleCount / capacity + 1;
            // }
            //second solution:

            int courses = (int)Math.Ceiling((double)peopleCount / capacity);
            Console.WriteLine(courses);
        }
    }
}
