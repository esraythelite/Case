using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoneity_Case_SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 4, 13, 8, 9, 7, 1, 6 };

            int[] outputArray = SortNumbers(inputArray);

            string result = "";

            foreach (int i in outputArray)
            {
                if (Array.IndexOf(outputArray,i) < outputArray.Length-1 )
                {
                    result += i.ToString() + ",";
                }
                else
                {
                    result += i.ToString();
                }
            } 

            Console.WriteLine($"The output is : [{result}]");

            Console.ReadLine();
        }

        public static int[] SortNumbers(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            int[] newArr = new int[arr.Length];
            int k = 0;
            int l = 1;
            for (int i = 0; i < arr.Length; i+=2)
            {
                newArr[k] = arr[i];
                k++;        
            }
            for (int j = 1; j < arr.Length; j+=2)
            {
                newArr[arr.Length-l] = arr[j];
                l++;
            }
            return newArr;
        }
    }
}
