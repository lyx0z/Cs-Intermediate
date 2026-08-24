namespace _04_ExceptionHandling;

public class Calculations
{
    //Schreibe eine Methode, welche als Input eine Ganzzahl entgegennimmt und überprüft ob diese positiv ist. Falls nicht soll eine Exception geworfen werden.
    public static void IsPositive(int userNumber)
    {
        if (userNumber < 0)
        {
            throw new ArithmeticException("Your number is negative");
        }
        Console.WriteLine("Your number is Positive");
    }
}
