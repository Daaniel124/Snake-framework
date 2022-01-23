using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake_framework
{
    class Game
    {
        public static void MainGame()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.SetBufferSize(80, 25);
            Sounds mu = new Sounds();
            mu.Play();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            //Отрисовка стен
            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка точек
            Console.ForegroundColor = ConsoleColor.Green;
            Point p = new Point(4, 5, '*');

            //Отрисовка змейки
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Отрисовка очков
            Console.ForegroundColor = ConsoleColor.Blue;
            Text.WriteText("Очки: 0", 81, 1);
            Score scores = new Score();

            //Отрисовка еды
            Console.ForegroundColor = ConsoleColor.Yellow;
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    scores.Increase();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    snake.Move();
                }

                Thread.Sleep(Speed.SnSped(Score.playerScore));

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            GameOver end = new GameOver();
            end.WriteGameOver();
        }
    }
}

