namespace _03_StaticClassesAndMethods;

//Schreibe eine Klasse, die alle Grundfunktionalität eines Taschenrechners anbieten soll. Die Klasse und ihre Methoden soll statisch sein und entsprechend aufgerufen werden. Nutze Exceptions wo dies sinnvoll ist.
public class Calculator
{
    public static int Sum(int x, int y)
    {
        var z = x + y;
        return z;
    }

    public static int Difference(int x, int y)
    {
        var z = x - y;
        return z;
    }

    public static int Multiplication(int x, int y)
    {
        var z = x * y;
        return z;
    }

    public static int Division(int x, int y)
    {
        var z = x / y;
        return z;
    }
}
