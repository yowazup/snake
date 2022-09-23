﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snakes : Figure
    {
       
        public Direction direction;
        public Snakes(Point tail, int lenght, Direction _direction)
        {

                direction = _direction;
                plist = new List<Point>();
                for (int i = 0; i < lenght; i++)
                {
                    Point p = new Point(tail);
                    p.Move(i, direction);
                    plist.Add(p);
                }
                    
        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            tail.Clear();

            Point head = GetNextPoint();
            plist.Add(head);             
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        
        }
    

        public void Turns (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;

        }
                    


    }
}
