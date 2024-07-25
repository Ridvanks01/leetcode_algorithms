public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        int lastIndex = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                while (nums[lastIndex] == val)
                {
                    lastIndex--;
                }

                nums[i] = nums[lastIndex];

                lastIndex--;

                k++;
            }
        }

        return nums.Length - k;

    }
}