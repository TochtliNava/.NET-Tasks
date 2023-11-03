﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Task 1.2
             * 
             *      THE ISBN PROBLEM
             *  
            */

            Console.WriteLine("Enter the 9 numbers of the ISBN code:");
            string isbn = Console.ReadLine();


            /**  
             * Task 1.3
            */

            //  Takes the number of elements of the array
            Console.WriteLine("Enter the number of elements of the array:");
            int length = int.Parse(Console.ReadLine());

            int[] baseArray = new int[length];
            int[] tempfilteredArray = new int[length];
            
            //  Reads the elements providen by the user
            for (int index = 0; index < baseArray.Length; index++)
            {
                Console.WriteLine($"Enter the value for the {index} index:");
                baseArray[index] = int.Parse(Console.ReadLine());
            }

            //  Writes in Console the array entered by user
            Console.WriteLine("Array entered by the user:");

            foreach (var item in baseArray)
            {
                Console.Write($"{item.ToString()} ");
            }

            Console.WriteLine();
            Console.WriteLine("Array filtered:");

            //  Runs over the baseArray and copy only the elements which are not allocated in tempFilteredArray
            int size = 0;

            for (int index = 0; index < baseArray.Length; index++)
            {
                // checks if the value is stored in tempfilteredarray
                if(Array.IndexOf(tempfilteredArray, baseArray[index]) == -1)
                {
                    // copy the value to the temparray
                    tempfilteredArray[size] = baseArray[index];
                    size++;
                }
            }
            
            //  size would be the size of the pre filtered array, now, only we need to do is to crop all the 0's
            int[] filteredArray = new int[size];

            for (int index = 0; index < size; index++)
            {
                filteredArray[index] = tempfilteredArray[index];
            }

            //  Writes in Console the array filtered
            foreach (var item in filteredArray)
            {
                Console.Write($"{item.ToString()} ");
            }
        }
    }
}
