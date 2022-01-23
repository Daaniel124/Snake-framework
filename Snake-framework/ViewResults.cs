using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_framework
{
    class ViewResults
    {
        public static void Results()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int xOffset = 30;
            int yOffset = 6;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Console.SetCursorPosition(xOffset, yOffset++);
            Console.ForegroundColor = ConsoleColor.Red;
            Text.WriteText("----------------------------", xOffset - 8, yOffset++);

            Console.ForegroundColor = ConsoleColor.Green;
            Text.WriteText("Результаты", xOffset + 1, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.Blue;
            Text.WriteText("Очки   Имя", xOffset, yOffset++);

            Console.ForegroundColor = ConsoleColor.Yellow;
            /*Score names = new Score();
            string results = names.ScoresRead();*/
            Score.ScoresRead(xOffset, yOffset++);

            Console.ReadLine();
        }
    }
}
