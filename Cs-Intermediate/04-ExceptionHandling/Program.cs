using System.Numerics;

namespace _04_ExceptionHandling;

public static class ExceptionHandling
{
    /*public static void Main(String[] args)
    {
        Console.WriteLine("Input your Number");
        var x = int.TryParse(Console.ReadLine(), out var userNumber);
        if (!x)
        {
            throw new Exception("cannot use a string");
        }

        const int maxValue = Int32.MaxValue;

        // Calculations.IsPositive(userNumber);
        var userNumber2 = 10;
        var result = Calculations.AddNums(userNumber, userNumber2);
        Console.WriteLine(result);
    }*/
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
