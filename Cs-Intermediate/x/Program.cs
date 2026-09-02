namespace MyNamespace;

public class Program
{
    public static void Main()
    {
        try
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[110]);
        }
        catch (Exception e) { }
    }
}
