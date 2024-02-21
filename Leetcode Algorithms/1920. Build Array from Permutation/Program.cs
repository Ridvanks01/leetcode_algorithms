using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1920.Build_Array_from_Permutation
{
    internal class Program
    {
        public int[] BuildArray(int[] nums)
        {
            int[] newArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                newArray[i] = nums[nums[i]];
            }

            return newArray;
        
        }
    }
}
