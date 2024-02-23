using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1470.Shuffle_the_Array
{
    internal class Program
    {
        public int[] Shuffle(int[] nums, int n)
        {

            List<int> newList = new List<int>();

            int index1 = 0;
            int index2 = n;

            for (int i = 0; i<n; i++)
            {
                newList.Add(nums[index1]);
                newList.Add(nums[index2]);

                index1++;
                index2++;
            }

            return newList.ToArray();
        }
    }
}
