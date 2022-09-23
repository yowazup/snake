using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Verticalline : Figure
    {

        public Verticalline(int yTop, int yBot, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yTop; y <= yBot; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

            }

        }

     

    }
}
