public class Solution
{

    static void Main(string[] args)
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };

        int val = 2;

        RemoveElement(nums, val);
    }

    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        int lastIndex = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Length == 1)
                break;
                

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