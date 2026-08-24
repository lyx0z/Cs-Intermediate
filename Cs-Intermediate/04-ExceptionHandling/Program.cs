namespace _04_ExceptionHandling;

public static class ExceptionHandling
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Input your Number");
        int.TryParse(Console.ReadLine(), out var userNumber);
        Calculations.IsPositive(userNumber);
    }
}
