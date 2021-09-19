using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Get Smallest number in a list");
            var numbers = new List<int>{ 1, 2, 3, 4, 5, 6 };
            var buffer = new List<int>();
            var smallest = numbers[0];
            for(var i=0; i< numbers.Count; i++)
            {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine("smallest number is " + smallest);
        }
    }
}
