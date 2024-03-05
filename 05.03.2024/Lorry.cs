using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    internal class Lorry:Vehicle
    {
        public int MaxCapacity {  get; set; }
        public Lorry() { }
        public Lorry(int price,int maxSpeed,int year,int maxCapacity):base(price,maxSpeed,year) 
        {
         MaxCapacity = maxCapacity;
        }
        public override string Print()
        {
            return $"Price:{Price}\tMax Speed:{MaxSpeed}\tYear:{Year}\tMax capacity:{MaxCapacity}";
        }
    }
}
