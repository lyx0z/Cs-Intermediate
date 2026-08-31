namespace Extra_TwoSum;

public static class Program
{
    public static void Main(String[] args)
    {
        int[] numbers = [15, 7, 11, 2];
        var target = 9;
        var twoSummed = TwoSumMethod.TwoSum(numbers, target);

        foreach (var num in twoSummed)
        {
            Console.WriteLine(num);
        }
    }
}
