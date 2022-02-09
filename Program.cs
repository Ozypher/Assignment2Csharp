using System;
/*1. When to use string vs StringBuilder in C#?
 * -If a string is going to change many times, use the StringBuilder class object.  If it stays the same, use the String class object.
 *2.What is the base class for all arrays in C#?
 * -The array class
 *3.How do you sort an array in C#?
 * -Array.sort()
 *4.What property of an array object can be used to get the total number of elements in an array?
 * -Array.length()
 *5.Can you store multiple data types in System.Array?
 * -no
 *6.What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
 * -Clone makes a new array, copy to copies it to a different array
 */
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copyArray = new int[testArray.Length];
            foreach(int i in testArray)
            {
                Console.WriteLine("test:"+testArray[i-1]);
                copyArray[i-1] = testArray[i-1];
                Console.WriteLine("copy:"+copyArray[i-1]);
            }
        }
    }
}
