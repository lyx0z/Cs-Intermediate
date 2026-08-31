namespace _06_AdvancedTasks;

public class DrawingMaker
{
    public static void Draw(bool[,] matrix)
    {
        for (var row = 0; row < matrix.GetLength(0); row++)
        {
            for (var col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] ? 'x' : ' ');
            }
            Console.WriteLine();
        }
    }
}
