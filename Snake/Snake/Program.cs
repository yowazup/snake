// See https://aka.ms/new-console-template for more information
using Snake;
using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 26);

            Walls walls = new Walls(80, 26);
            walls.Draw();


            //Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snakes snake = new Snakes(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 26, '$');
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
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Turns(key.Key);
                }
            }
        }
    }
}