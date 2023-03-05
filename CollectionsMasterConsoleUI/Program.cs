using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            //DONE
            var myArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //DONE
            Populater(myArray);

            //TODO: Print the first number of the array
            //DONE
            Console.WriteLine($"The first number in my array is {myArray[0]}");

            //TODO: Print the last number of the array
            //DONE
            Console.WriteLine($"The last number in my array is {myArray[49]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //DONE
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            // 1) attempt for number 1
            //DONE
            //Enumerable keeps the original array in the original order
            var revArray = Enumerable.Reverse(myArray);
            
            Console.WriteLine("All Numbers Reversed:");
            foreach (int num in revArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------REVERSE CUSTOM------------");
            //DONE
            ReverseArray(myArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            //DONE
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            //sortArray is used so that I do not change myArray's original order
            //var sortArray = myArray;
            
            var n = myArray.Length;
            var sortArray = new int[n];
            for (var i = 0; i < n; i++)
            {
                sortArray[i] = myArray[i];
            }
            Array.Sort(sortArray);
            Console.WriteLine("Sorted numbers:");
            foreach (var item in sortArray)
            {
                Console.WriteLine(item);
            }
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            

            //TODO: Print the capacity of the list to the console
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            

            //TODO: Print the new capacity
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            //I did not create or change the original array
            //I just printed the numbers from the array given a condition
            var n = numbers.Length;
            var zero = 0;
            for (var i = 0; i < n; i++)
            {
                if (numbers[i]%3 == 0)
                {
                    Console.WriteLine(zero);
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (var i=0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0,51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            int n = array.Length;
            var tempArray = new int[n];

            for (var i = 0; i < n; i++)
            {
                tempArray[i] = array[n - i - 1];
            }
            foreach (var item in tempArray)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
