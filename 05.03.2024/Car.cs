using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    internal class Car:Vehicle
    {
        public int Power {  get; set; }
        public Car() { }
        public Car(int price,int maxSpeed,int year,int power):base(price,maxSpeed,year) 
        {
         Power = power;
        }
        public override string Print()
        {
            return $"Price:{Price}\tMax Speed:{MaxSpeed}\tYear:{Year}\tPower{Power}\n";
        }
    }
}
