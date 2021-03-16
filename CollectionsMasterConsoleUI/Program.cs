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
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50

            var numbers = new int[50];




            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            

            //Print the first number of the array
            Console.WriteLine(numbers[0]);

            //Print the last number of the array            
            Console.WriteLine(numbers [numbers.Length -1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            //numbers.Reverse();

            ReverseArray(numbers);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var nums = new List<int>();

            //Print the capacity of the list to the console

            Console.WriteLine(nums.Capacity);
            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(nums);

            //Print the new capacity

            Console.WriteLine(nums.Capacity);
            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            //Console.WriteLine("What number will you search for in the number list?");

            NumberChecker(nums);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(nums);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(nums);
            NumberPrinter(nums);

            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");

            nums.Sort();

            
            Console.WriteLine("------------------");
            NumberPrinter(nums);
            //Convert the list to an array and store that into a variable
            

            //Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i]%3 == 0)
                {
                    numbers[i] = 0;
                }
                   
            } 
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count -1; i++)
            {
                if (numberList[i] %2 != 0)
                {
                    numberList[i] = 0;
                }
            } 
        }

        private static void NumberChecker(List<int> numberList)
        { int numberInput;
            Console.WriteLine("What number are you checking for?");
            var isNumber = int.TryParse(Console.ReadLine(), out numberInput );

            if (isNumber == false)
            {
                Console.WriteLine("That is not a number");
                
            }

            else if (numberList.Contains(numberInput))
            {
                Console.WriteLine($"Found {numberInput}");
            }


        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(50));
            }
            
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
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
