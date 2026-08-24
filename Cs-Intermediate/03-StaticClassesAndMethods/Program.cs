namespace _03_StaticClassesAndMethods;

public static class StaticClassesAndMethods
{
    public static void Main(String[] args)
    {
        var x = 5;
        var y = 0;
        try
        {
            var result = Calculator.Division(x, y);
            Console.WriteLine(result);
        }
        catch (Exception dividebyzero)
        {
            Console.WriteLine(dividebyzero.Message);
        }
    }
}
