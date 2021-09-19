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
            var smallest = GetSmallest(numbers, 3);

            foreach(var number in smallest)
            {
                Console.WriteLine("smallest number is " + number);
            }

        }

        public static List<int> GetSmallest(List<int> list, int count)
        {
            var buffer = new List<int>();
            while(buffer.Count < count)
            {
                var min = Smallest(list);
                buffer.Add(min);
                list.Remove(min);
            }
            return buffer;
        }

        public static int Smallest(List<int> list)
        {
            var smallest = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                }
            }
            return smallest;
        }
    }
}
