using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snakes : Figure
    {
        public Snakes(Point tail, int lenght, Direction direction)
        {

      
                plist = new List<Point>();
                for (int i = 0; i < lenght; i++)
                {
                    Point p = new Point(tail);
                    p.Move(i, direction);
                    plist.Add(p);
                }
                    
        }


    }
}
