﻿using System;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.1

            Console.WriteLine("Enter the number A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number B:");
            int b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                (a, b) = (b, a);
            }

            Console.WriteLine("Number(s) that has AA in the DuoDecimal system:");

            DiscoverJustAA(a, b);

            // Task 1.2

            // Takes the user's ISBN code
            Console.WriteLine("Enter the 9 numbers of the ISBN code:");
            string isbn = Console.ReadLine();

            // Can't store a char to number in a int variable
            double total = 0;

            //  Multiply ISBN code by their coeficients
            for (int index = 0; index < isbn.Length; index++)
            {
                total += (10 - index) * char.GetNumericValue(isbn[index]);
            }

            Console.WriteLine("The ISBN code with the check code:");
            //  total mod 11
            total = total % 11;

            // get what it needs to become a multiply of 11, so that number is the check digit
            string code = (11 - total == 10) ? $"{isbn}-X" : $"{isbn}-{11 - total}";
            Console.WriteLine(code);

            //  Task 1.3

            //  Takes the number of elements of the array
            Console.WriteLine("Enter the number of elements of the array:");
            int lengthArray = int.Parse(Console.ReadLine());

            int[] baseArray = new int[lengthArray];
            int[] tempfilteredArray = new int[lengthArray];

            //  Reads the elements providen by the user
            for (int index = 0; index < baseArray.Length; index++)
            {
                Console.WriteLine($"Enter the value for the {index} index:");
                baseArray[index] = int.Parse(Console.ReadLine());
            }

            //  Writes in Console the array entered by user
            Console.WriteLine("Array entered by the user:");

            PrintArray(baseArray);

            Console.WriteLine();
            Console.WriteLine("Array filtered:");

            //  Runs over the baseArray and copy only the elements which are not allocated in tempFilteredArray
            int size = 0;

            for (int index = 0; index < baseArray.Length; index++)
            {
                // checks if the value is stored in tempfilteredarray
                if (Array.IndexOf(tempfilteredArray, baseArray[index]) == -1)
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
            PrintArray(filteredArray);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item.ToString());
            }
        }

        static void DiscoverJustAA(int start, int finish)
        {
            string hasDoubleAA = "";

            // Checks every number from A to B and prints every number that has double AA
            for (int currentNumber = start; currentNumber < finish + 1; currentNumber++)
            {
                int count = 0;
                foreach (var c in ConvertToDuoDecimal(currentNumber))
                {
                    if (c == 'A')
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    hasDoubleAA += currentNumber.ToString() + " ";
                }
            }

            if (hasDoubleAA.Length != 0)
            {
                Console.WriteLine(hasDoubleAA);
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static char[] ConvertToDuoDecimal(int number)
        {
            string duodecimalNumber = "";
            char[] duoNumber;

            //  Checks if the number is negative
            if (number < 0)
            {
                number *= -1;
            }

            // Convert the decimal number to duodecimal by the division method
            while (number > 2)
            {
                if (number % 12 == 10)
                {
                    duodecimalNumber += "A";
                }
                if (number % 12 == 11)
                {
                    duodecimalNumber += "B";
                }
                if (number % 12 != 11 && number % 12 != 10)
                {
                    duodecimalNumber += (number % 12).ToString();
                }
                number = number / 12;
            }

            // Converts the duodecimal number to a charArray to finally reverse it
            duoNumber = duodecimalNumber.ToCharArray();
            Array.Reverse(duoNumber);
            return duoNumber;
        }
    }
}
