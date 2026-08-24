namespace _03_StaticClassesAndMethods;

//Schreibe eine Klasse, die alle Grundfunktionalität eines Taschenrechners anbieten soll. Die Klasse und ihre Methoden soll statisch sein und entsprechend aufgerufen werden. Nutze Exceptions wo dies sinnvoll ist.
public class Calculator
{
    public static void Sum(int x, int y)
    {
        var z = x + y;
        Console.WriteLine(z);
    }

    public static void Difference(int x, int y)
    {
        var z = x - y;
        Console.WriteLine(z);
    }

    public static void Multiplication(int x, int y)
    {
        var z = x * y;
        Console.WriteLine(z);
    }

    public static void Division(int x, int y)
    {
        var z = x / y;
        Console.WriteLine(z);
    }
}
