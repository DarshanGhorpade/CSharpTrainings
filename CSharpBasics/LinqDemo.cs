/*
 * Language Integrated Query LINQ C#
 * LINQ is a data querying API with SQL like query syntaxes.
 * Advantages:
 * 1. LINQ offers an object-based, language-integrated way to query over data no matter where that data came from.
 * So through  LINQ we can query database, XML as well as collections.
 * 2. Compile time syntax checking
 * 3. It allows you to query collections like arrays, enumerable classes etc in the native language of your application,
 * like VB or C# in much the same way as you would query a database using SQL
 */

using System;

namespace CSharpBasics
{
    internal class LinqDemo
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 1, 2 , 3, 4, 5};
            var res = from a in nums where a < 3 orderby a select a;
            foreach (var i in res)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}