using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaExam
{
    internal class Point
    {
        string name;
        int x;
        int y;

        public string Name { get => name; }
        public int X { get => x; }
        public int Y { get => y; }
        public Point(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
        public static Point Init()
        {
            string name = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return new Point(name, x, y);
        }

    }
}
