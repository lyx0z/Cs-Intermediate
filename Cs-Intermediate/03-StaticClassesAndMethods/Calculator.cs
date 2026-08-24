namespace _03_StaticClassesAndMethods;

//Schreibe eine Klasse, die alle Grundfunktionalität eines Taschenrechners anbieten soll. Die Klasse und ihre Methoden soll statisch sein und entsprechend aufgerufen werden. Nutze Exceptions wo dies sinnvoll ist.
public static class Calculator
{
    public static int Sum(int addend1, int addend2)
    {
        return addend1 + addend2;
    }

    public static int Difference(int minuend, int subtrahend)
    {
        return minuend - subtrahend;
    }

    public static int Multiplication(int factor1, int factor2)
    {
        return factor1 * factor2;
    }

    public static int Division(int dividend, int divisor)
    {
        var quotient = 0;
        try
        {
            quotient = dividend / divisor;
        }
        catch (DivideByZeroException dividebyzero)
        {
            Console.WriteLine(dividebyzero.Message);
        }

        return quotient;
    }
}
