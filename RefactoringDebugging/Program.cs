using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };

            /*I decided to comment out the for loop since the loop was changing the elements in the array
            It went from {1,2,3,4,5,6} to [2,3,4,5,6,7} so the sum was 27 instead of 21
            Now the resulting sum is 21 

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i]++;
            }
            */

            int result = GetSum(array1);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static int GetSum(int[] array1)
        {
            //Sum was initialized to 1 originally, changed it to start at 0
            int sum = 0;
            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;
        }
    }
}
