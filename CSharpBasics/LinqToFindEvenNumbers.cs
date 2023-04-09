using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class LinqToFindEvenNumbers
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            // Write a simple C# program to declare a list of integer values,
            // followed by a simple LINQ query to check for even numbers, 
            // and finally print them to the console.

            // Step 1: Getting data source
            var nums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Using Existing .NET Features");
            foreach (var number in nums)
            {
                if (number % 2 == 0)
                    Console.WriteLine(number);
            }

            Console.WriteLine("Using LINQ");


            // Step 2: Query creation
            // Part 1: Data source
            // Part 2: Filter    
            // Part 3: Select
            var res = from a in nums where a % 2 == 0 select a;
            
            // Step 3: Query execution
            foreach (var i in res)
                Console.WriteLine(i);
        }
    }
}
