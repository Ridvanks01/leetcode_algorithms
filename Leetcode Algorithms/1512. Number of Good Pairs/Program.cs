using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1512.Number_of_Good_Pairs
{
    internal class Program
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int goodPairs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        goodPairs++;
                    }
                }
            }

            return goodPairs;
        }
    }
}
