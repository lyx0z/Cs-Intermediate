namespace Extra_TwoSum;

public static class Program
{
    public static void Main()
    {
        int[] numbers = [15, 7, 11, 2];
        var target = 9;
        var twoSummed = TwoSum(numbers, target);

        foreach (var num in twoSummed)
        {
            Console.WriteLine(num);
        }
    }

    private static int[] TwoSum(int[] nums, int target)
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
