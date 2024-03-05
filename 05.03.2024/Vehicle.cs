using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    abstract class Vehicle
    {
        public int Price { get; set; }
        public int MaxSpeed {  get; set; }
        public int Year {  get; set; }
        public Vehicle() { }
        public Vehicle(int price, int maxSpeed,int year) 
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
        }
        public abstract string Print();
    }
}
