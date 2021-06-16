using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new List<int>();
        


        //TODO:

        // Create an int Array and populate numbers 1-10
        int[] NewArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        /* Create two Lists of type int.
         * Name one List "evens"
         * Name the other List "odds"
         */

        List<int> odd = new List<int>();
             //
        List<int> even = new List<int>();
       // { 2, 4, 6, 8, 10 };
        /* Using either a foreach or for loop,
         * nest an if statement to check to see
         *  if a number is even or odd.
         * Then add those numbers to either the evens List
         * or the odds List
         */

        foreach(var number in NewArray)
            {
                if(number % 2 == 0)
                {
                    even.Add(number);
                    Console.WriteLine($"{number} is even");
                }
                else
                {
                    odd.Add(number);
                    Console.WriteLine($"{number} is odd");

                }
             

            }

            foreach (int number in even) ;
            {
                Console.WriteLine($"this is the list for even numbers {NewArray}");
            }

            foreach (int number in even) ;
            {
                Console.WriteLine($"this is the list for odd numbers {NewArray}");
            }









        /* Now using foeach or for loops,
         * display each List of even and odd numbers
         *
         * Try to be creative in your display
         */
        }
    }
}
