using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    internal class Bicycle:Vehicle
    {
        public int KvoMest {  get; set; }
        public Bicycle() { }
        public Bicycle(int price,int maxSpeed,int year,int kvoMest):base(price,maxSpeed,year) 
        {
            KvoMest=kvoMest;
        }
        public override string Print()
        {
            return $"Price:{Price}\tMax Speed:{MaxSpeed}\tYear:{Year}\tPlaces:{KvoMest}";
        }
    }
}
