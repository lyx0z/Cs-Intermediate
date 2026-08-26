namespace _06_AdvancedTasks;

public class AdvancedTasks
{
    public static void Main(String[] args)
    {
        //Erweitere das Programm so, dass es das Array auf die Konsole schreiben kann, Werte welche false sind, sollen Leerzeichen sein, true sollen etwas schreiben, z.B. ein 'x'
        var matrix = new bool[6, 9]
        {
            { false, false, false, false, true, false, false, false, false },
            { false, false, false, true, true, true, false, false, false },
            { false, false, true, true, true, true, true, false, false },
            { false, true, true, true, true, true, true, true, false },
            { true, true, true, true, true, true, true, true, true },
            { false, false, false, false, true, false, false, false, false },
        };
        var draw = new DrawingMaker();
        draw.Draw(matrix);
    }
}
