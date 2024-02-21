using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929.Concatenation_of_Array
{
    internal class Program
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] newArray = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                newArray[i] = nums[i];
                newArray[i + nums.Length] = nums[i];
            }

            return newArray;

        }
    }
}
