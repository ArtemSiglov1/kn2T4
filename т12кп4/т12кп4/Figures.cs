using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace т12кп4
{
    internal class Figures
    {
        string name;
        double side1, side2,side3;
        public Figures() { } 
        public Figures(string name, double side1, double side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }
        public override string ToString()
        {
            return $"Название-{name}\tстороны={side1}\t{side2}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Side1
        { get { return side1; } set {  side1 = value; } }

        public double Side2
        { get { return side2; } set {  side2 = value; } }

        public void PS()
        {
            double perimetre = (side1 + side2) * 2;

            double square = side1 * side2;
            Console.WriteLine($"per={perimetre}, sq={square}");
        }
        public void PS1()
        {
            double perimetre = side1 + side2 + side3;
            double p = perimetre / 2;
            double square = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            Console.WriteLine($"per={perimetre}, sq={square}");
        }
        public Figures(string name, int side1, int side2, int side3) : this(name, side1, side2)
        {
            this.side3 = side3;
        }
        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }

    }
}
