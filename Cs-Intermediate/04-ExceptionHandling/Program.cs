using System.Numerics;

namespace _04_ExceptionHandling;

public static class ExceptionHandling
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Input your Number");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var userNumber))
        {
            throw new Exception("user input mistake");
        }
        var userNumber2 = int.MaxValue;
        var result = Calculations.AddNums(userNumber, userNumber2);
        Console.WriteLine(result);
    }
}
