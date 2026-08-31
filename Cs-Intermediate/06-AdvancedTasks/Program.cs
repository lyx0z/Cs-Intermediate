using _06_AdvancedTasks;

namespace _06_Advancedasks;

public static class AdvancedTasks
{
    public static void Main(String[] args)
    {
        var running = true;
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
        //DrawingMaker.Draw(matrix);
        //Erstelle ein Consolenprogramm, welches ein X automatisch über den Bildschirm laufen lässt. +wasd
        var leftPos = 0;
        var topPos = 0;
        while (running)
        {
            var key = Console.ReadKey();
            Console.SetCursorPosition(leftPos, topPos);
            Console.Write("X");
            if (key.KeyChar == 'w')
            {
                Console.Clear();
                topPos -= 1;
                if (topPos < 0)
                {
                    Console.SetCursorPosition(leftPos, topPos = 0);
                    Console.Write("X");
                }
                else
                {
                    Console.SetCursorPosition(leftPos, topPos);
                    Console.Write("X");
                }
            }
            if (key.KeyChar == 'a')
            {
                Console.Clear();
                leftPos -= 1;
                if (leftPos < 0)
                {
                    Console.SetCursorPosition(leftPos = 0, topPos);
                    Console.Write("X");
                }
                else
                {
                    Console.SetCursorPosition(leftPos, topPos);
                    Console.Write("X");
                }
            }
            if (key.KeyChar == 's')
            {
                Console.Clear();
                topPos += 1;
                if (topPos >= 30)
                {
                    Console.SetCursorPosition(leftPos, topPos = 29);
                    Console.Write("X");
                }
                else
                {
                    Console.SetCursorPosition(leftPos, topPos);
                    Console.Write("X");
                }
            }

            if (key.KeyChar == 'd')
            {
                Console.Clear();
                leftPos += 1;
                if (leftPos >= 120)
                {
                    Console.SetCursorPosition(leftPos = 119, topPos);
                    Console.Write("X");
                }
                else
                {
                    Console.SetCursorPosition(leftPos, topPos);
                    Console.Write("X");
                }
            }
        }
    }
}
