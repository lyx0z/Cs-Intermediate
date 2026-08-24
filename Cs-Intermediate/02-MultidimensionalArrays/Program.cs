using System.Linq.Expressions;

namespace _02_MultidimensionalArrays;

public static class MultidimensionalArrays
{
    public static void Main(String[] args)
    {
        //Schreibe eine Methode, welche für einen beliebigen zweidimensionalen Array mit dem Typ Integer die Summe aller Elemente zurückgibt. (Bsp.: var multiDimensionalArray = new int[5, 2] { { 1, 2, }, { 4, 5 }, { 8, 9 }, { 17, 2 }, { 2, 9 } }; )
        var multiDimensionalArray1 = new int[5, 2]
        {
            { 1, 2 },
            { 4, 5 },
            { 8, 9 },
            { 17, 2 },
            { 2, 9 },
        };
        var sum = MultidimensionalArrSum(multiDimensionalArray1);
        Console.WriteLine(sum);

        var multiDimensionalArray = new int[2, 2]
        {
            { 1, 2 },
            { 4, 5 },
        };
        var newArray = RowSum(multiDimensionalArray);
        foreach (var i in newArray)
        {
            Console.WriteLine(i);
        }
    }

    private static int MultidimensionalArrSum(int[,] arr)
    {
        var sum = 0;
        // var sum = arr.Cast<int>().Sum();
        for (var row = 0; row < arr.GetLength(0); row++)
        {
            for (var col = 0; col < arr.GetLength(1); col++)
            {
                sum += arr[row, col];
            }
        }
        return sum;
    }

    private static int[] RowSum(int[,] multiDimensionalArray)
    {
        var newArray = new int[multiDimensionalArray.GetLength(0)];
        for (var row = 0; row < multiDimensionalArray.GetLength(0); row++)
        {
            var sum = 0;
            for (var col = 0; col < multiDimensionalArray.GetLength(1); col++)
            {
                sum += multiDimensionalArray[row, col];
            }

            newArray[row] = sum;
        }
        return newArray;
    }
}
