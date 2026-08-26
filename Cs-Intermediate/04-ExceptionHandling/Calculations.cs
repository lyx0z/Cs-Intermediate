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

    //Schreibe eine Methode die zwei Integer-Zahlen miteinander addiert und diese zurückgibt. Finde zuerst heraus, welche Exceptions dabei auftreten können und fange diese geeignet ab.
    public static int AddNums(int userNumber1, int userNumber2)
    {
        checked
        {
            return userNumber1 + userNumber2;
        }
    }
}
