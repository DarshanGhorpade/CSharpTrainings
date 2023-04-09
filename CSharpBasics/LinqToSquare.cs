using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class LinqToSquare
    {
        static void Main(string[] args)
        {
            // Write a simple C# program to declare a list of integer numbers, 
            // followed by writing queries using both query and method syntax 
            // to calculate their square (num * num), and finally print them to the console.

            // Step 1: Getting data source
            var nums = new int[] { 1, 2, 3, 4, 5 };

            // Query syntax
            // Step 2: Writing query 
            var res = from a in nums select a * a;
            // OR
            //var res = nums.Select(a => a * a);

            // Method syntax
            // Step 3: Executing query 
            foreach(var x in res)
                Console.WriteLine(x);
        }
    }
}
