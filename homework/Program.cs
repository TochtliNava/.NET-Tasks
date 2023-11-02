using System;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**  
             * Task 1.3
            */

            //  Takes the number of elements of the array
            Console.WriteLine("Enter the number of elements of the array:");
            int length = int.Parse(Console.ReadLine());

            int[] baseArray = new int[length];
            
            for (int index = 0; index < baseArray.Length; index++)
            {
                Console.WriteLine($"Enter the value for the {index} index:");
                baseArray[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array entered by the user:");

            foreach (var item in baseArray)
            {
                Console.Write($"{item.ToString()} ");
            }

            Console.WriteLine("Array filtered:");

        }
    }
}
