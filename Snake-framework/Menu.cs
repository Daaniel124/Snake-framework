using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    class Menu
    {
        public static int Start()
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();

            int xOffset = 30;
            int yOffset = 6;


            Console.SetCursorPosition(xOffset, yOffset++);
            Console.ForegroundColor = ConsoleColor.Red;
            Text.WriteText("----------------------------", xOffset - 8, yOffset++);

            Console.ForegroundColor = ConsoleColor.Green;
            Text.WriteText("Игра 'Змейка'", xOffset, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.Blue;
            Text.WriteText("Меню", xOffset - 3, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Text.WriteText("1 - Начать игру", xOffset - 7, yOffset++);
            Text.WriteText("2 - Результаты игроков", xOffset - 7, yOffset++);
            Text.WriteText("3 - Выйти из игры", xOffset - 7, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.Green;
            Text.WriteText("Введите номер: ", xOffset - 3, yOffset++);

            Console.ForegroundColor = ConsoleColor.Red;
            Text.WriteText("----------------------------", xOffset - 8, yOffset++);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(42, 16);
            int choice = int.Parse(Console.ReadLine());

            int m = 3;
            if (choice == 1)
            {
                m = 1;
            }
            if (choice == 2)
            {
                m = 2;
            }
            if (choice == 3)
            {
                m = 3;
            }
            return m;

        }
    }
}

