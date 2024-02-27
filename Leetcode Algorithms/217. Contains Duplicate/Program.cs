using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217.Contains_Duplicate
{
    internal class Program
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(nums[i]);
            }

            if(nums.Length != numbers.Count)
                return true;
            else
                return false;

        }
    }
}
