namespace Extra_TwoSum;

public class TwoSumMethod
{
    public static int[] TwoSum(int[] nums, int target)
    {
        for (var index = 0; index < nums.Length; index++)
        {
            for (var nextIndex = index + 1; nextIndex < nums.Length; nextIndex++)
            {
                if (nums[index] + nums[nextIndex] == target)
                {
                    return [index, nextIndex];
                }
            }
        }

        return [];
    }
}
