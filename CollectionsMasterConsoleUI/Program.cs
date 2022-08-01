using System;
using System.Collections.Generic;

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

            var myArr = new int[50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(myArr);
            //TODO: Print the first number of the array
            Console.WriteLine("First num");
            Console.WriteLine($"{myArr[0]}");
            //TODO: Print the last number of the array
            Console.WriteLine("Last num");
            Console.WriteLine($"{myArr[myArr.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArr);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(myArr);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(myArr);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(myArr);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArr);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(myArr);
            NumberPrinter(myArr);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var IntList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("capacity");
            Console.WriteLine(IntList.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(IntList);

            //TODO: Print the new capacity


            Console.WriteLine("new capacity");
            Console.WriteLine(IntList.Count);

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int userNumInt = Console.ReadLine();
            string userName = Console.ReadLine();
            bool sucess = int.TryParse(userName, out userNumInt);
            if (sucess)
            {
                NumberChecker(IntList, userNumInt);
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(IntList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(IntList);
            NumberPrinter(IntList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            IntList.Sort();
            NumberPrinter(IntList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] InListArray = IntList.ToArray();
            //TODO: Clear the list
            IntList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] num)
        { for (int = 0; i < num.Length; i++) 
            {
                if (num[i] % 3 == 0)
                {
                    num[i] = 0;
                }
            }
            foreach (int i in num) {

                Console.WriteLine(i);
                }
            }
        private static void OddKiller(List<int> numberList)
        {
            var tarVal = new List<int>();

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    tarVal.Add(numberList[i]);
                }
            }

            numberList.Clear();
            foreach (int i in tarVal) {
                numberList.Add(i);

            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool numberFound = false;
            Console.WriteLine("checking your number....");
            foreach (int number in numberList)
            {
                if (number == searchNumber)
                {
                    Console.WriteLine($"Your number {searchNumber} was found in the list!");
                    numberFound = true;
                    break;
                }
            }
            if (numberFound == false) { Console.WriteLine("Your number was not found."); }
        }


        private static void
        Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)

            { Random rng = new Random();
                numberList[i] = rng.Next(0, 50);
            }
        }
        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }

            private static void ReverseArray(int[] array)
            {
                
                int[] newArray = new int[50];
              
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[array.Length - 1 - i];
                }
                     
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = newArray[i];
                }
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

