using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace т15кп1
{
    internal class Sportiki
    {
        string surname, name, otchestvo;
        double height, weight;
        public static int count;
        public string Surname
        {
            get
            {
                string x = Surname == "" ? "Фамилии нет" : surname;
                return x;
            }
            set { surname = value; }
        }
        public string Name
        {
            get
            {
                string x = Name == "" ? "Имени нет" : name;
                return x;
            }
            set { name = value; }
        }
        public string Otchestvo
        {
            get
            {
                string x = Otchestvo == "" ? "Имени нет" : otchestvo;
                return x;
            }
            set { otchestvo = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Sportiki() { }
        static Sportiki()
        {
            count = 0;
        }
        public Sportiki(string surname, string name, string otchestvo, double height, double weight)
        {
            Surname = surname;
            Name = name;
            Otchestvo = otchestvo;
            Height = height;
            Weight = weight;
            if (Weight>70)
            {
                count++;
            }
            
        }
        public override string ToString()
        {
            return $"Surname-{surname}\nName-{name}\nOtchestvo-{otchestvo}\nHeight-{height}\nWeight-{weight}\n";
        }
       
    }
}
