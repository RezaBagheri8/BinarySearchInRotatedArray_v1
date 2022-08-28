using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchInRotatedArray
{
    public class BinarySearch
    {
        int first;
        int last;
        int[] array;
        public BinarySearch(int[] inputArray)
        {
            array = new int[inputArray.Length];
            array = inputArray;
        }

        public int IterativeSearch(int[] nums, int target)
        {
            int first = 0;
            int last = nums.Length - 1;
            int middle = (first + last) / 2;

            while (true)
            {
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (first > last)
                {
                    return -1;
                }
                else if (nums[middle] >= nums[first])
                {
                    if (target < nums[middle] && target >= nums[first])
                    {
                        last = middle - 1;
                        middle = (first + last) / 2;
                    }
                    else
                    {
                        first = middle + 1;
                        middle = (first + last) / 2;
                    }
                }
                else
                {
                    if (target > nums[middle] && target <= nums[last])
                    {
                        first = middle + 1;
                        middle = (first + last) / 2;
                    }
                    else
                    {
                        last = middle - 1;
                        middle = (first + last) / 2;
                    }
                }
            }
        }
    }
}
