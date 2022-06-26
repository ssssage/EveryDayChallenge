using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheChallenge
{
    // { 1, 3, 6, 7, 9 }, 3
    public class BinarySearch
    {
      public static int SearchTarget(int[] arr, int target)
        {
            return SearchTarget(arr, target, 0, arr.Length - 1);
        }

        public static int SearchTarget(int[] arr, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int expectedTarget = arr[middle];

                if (target == expectedTarget)
                {
                    return middle;
                }

                else if (target < expectedTarget)
                {
                    right = middle - 1;
                }

                else
                {
                    left = middle + 1;
                }

            }

            return -1;
        }
    }



}

//Time Complexity Big O(log (N))
//Space Complexity Big O(1)
// Tech Training Bootcamp UK





















/*
 
  // O(log(n)) time | O(log(n)) space
        public static int BinarySearchTarget(int[] array, int target)
        {
            return BinarySearchTarget(array, target, 0, array.Length - 1);
        }

        public static int BinarySearchTarget(int[] array, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int potentialMatch = array[middle];
                if (target == potentialMatch)
                {
                    return middle;
                }
                else if (target < potentialMatch)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
 */