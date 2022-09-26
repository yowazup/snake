using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Endgame : Figure
    {
        public Endgame(int xLeft, int yTop, char sym)
        {
            
            var xxx = new List <List<int>>

                {
                new () {0, 1, 2, 3, 6, 7, 8, 11, 12, 14, 15, 18, 19, 20},
                new () {0, 6, 8, 11, 13, 15, 18},
                new () {0, 2, 3, 6, 7, 8, 11, 13, 15, 18, 19},
                new () {0, 3, 6, 8, 11, 15, 18},
                new () {0, 1, 2, 3, 6, 8, 11, 15, 18, 19, 20},
                new () {},
                new () {2, 3, 4, 7, 9, 12, 13, 14, 17, 18, 19},
                new () {2, 4, 7, 9, 12, 17, 19},
                new () {2, 4, 7, 9, 12, 13, 17, 18, 19},
                new () {2, 4, 7, 9, 12, 17, 18},
                new () {2, 3, 4, 8, 12, 13, 14, 17, 19},
                new () {},
                new () {},
                new () {},
                new () {8, 9, 12, 13},
                new () {8, 9, 12, 13},
                new () {},
                new () {7, 8, 9, 10, 11, 12, 13, 14},
                new () {6, 15},
                };  

            //GAME
            plist = new List<Point>();
            var y = 0;

            foreach (var xx in xxx)
            {
                foreach (var x in xx)
                {
                    Point p = new Point(xLeft + x, yTop + y, sym);
                    plist.Add(p);                    
                }
                y++;
            }          
        }
    }
}

