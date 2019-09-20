/*
 * Author: Tyler Powell
 * Date: 09/17/2019
 * Comments: This C# Console Application creates an array of size 25 elements.
 *           It then populates those elements with values using a FOR loop.
 */

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Informs the user that an array will be populated
                Console.WriteLine("Populating an array of 25 elements...");
                // Creates an array named 'array' and assigns a size of 25 elements to it
                int[] array = new int[25];
                /* 
                 * This FOR loop creates and initalizes variable 'i' and tests certain conditions.
                 * The loop will then assign values to the 25 elements of the array. 
                 */
                for (int i = 0; i < 25; i++)
                {
                    array[i] = 1 + i;
                    Console.WriteLine("Element value = " + array[i]);
                }
                Console.WriteLine("Population Complete!");
                Console.WriteLine("");

                // After the intial 'population', the program asks the user to enter a new value for a size of an array
                Console.Write("Now pick a new size for the array: ");
                // Creates a variable named size and assigns to it what the user inputed
                int size = int.Parse(Console.ReadLine());
                // Creates another array, named 'array2', whose size is equal to the number the user inputed
                int[] array2 = new int[size];
                // This for loop loops through the amount of times equal to variable size.
                for (int j = 0; j < size; j++)
                {
                    array2[j] = 1 + j;
                    Console.WriteLine("Element value = " + array2[j]);
                }
                Console.WriteLine("Second population complete!");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Something went wrong. Please exit the program and try again...");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }
            // end of catch
        }
    }
}