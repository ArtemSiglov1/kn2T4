using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп2
{
    internal class Figura
    {
        public string name;
        public double str1;
        public double str2;

        public Figura() { } 
        public Figura(string name, double str1, double str2)
        {
            this.name = name;
            this.str1 = str1;
            this.str2 = str2;
            if(name=="квадрат" ^ name=="Квадрат")
            {
                this.str2 = str1;
            }    
        }
        public override string ToString()
        {
            Console.WriteLine($"Площадь фигуры={str1*str2}");
            return $"Name={name}\tStorona1={str1}\tStorona2={str2}";
            
        }

    }
}
