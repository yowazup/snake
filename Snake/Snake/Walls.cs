using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int MapWidth, int MapHeight)
        { 
        wallList = new List<Figure>();
           
            //Отрисовка рамочки
            Horizontalline uphline = new Horizontalline(0, MapWidth - 2, 0, '+');
            Horizontalline downhline = new Horizontalline(0, MapWidth - 2, MapHeight - 1, '+');
            Verticalline leftvline = new Verticalline(0, MapHeight - 1, 0, '+');
            Verticalline rightvline = new Verticalline(0, MapHeight - 1, MapWidth - 2, '+');

            wallList.Add(uphline);
            wallList.Add(downhline);
            wallList.Add(leftvline);
            wallList.Add(rightvline);

        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
