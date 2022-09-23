﻿// See https://aka.ms/new-console-template for more information
using Snake;
using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 40);

            //Отрисовка рамочка
            Horizontalline uphline = new Horizontalline(0, 78, 0, '+');
            Horizontalline downhline = new Horizontalline(0, 78, 25, '+');
            Verticalline leftvline = new Verticalline(0,25,0,'+');
            Verticalline rightvline = new Verticalline(0,25,78,'+');
            uphline.Drow();
            downhline.Drow();
            leftvline.Drow();
            rightvline.Drow();

            //Отрисовка точек
           
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }


    }
}