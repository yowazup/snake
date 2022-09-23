// See https://aka.ms/new-console-template for more information
using Snake;
using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(3, 2, '?');
            p3.Draw();

            Point p4 = new Point(0, 8, '@');
            p4.Draw();

            List<char> numlist = new List<char>();
            numlist.Add('#');
            numlist.Add('*');
            numlist.Add('!');

            char x = numlist[0];
            char y = numlist[1];
            char z = numlist[2];
            

            foreach (char i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);

            Console.ReadLine();
        }


    }
}