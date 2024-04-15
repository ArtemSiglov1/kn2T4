using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMagazin
{
    internal class Katalog:IComparable<Katalog>
    {
        public int Id {  get; set; }
        public string Label { get; set; }
        public int MaxSpeed {  get; set; }
        public int Price {  get; set; }
        public double Sale {  get; set; }
        public Katalog() { }
        public Katalog(int id, string label, int maxSpeed, int price, double sale)
        {
            Id = id;
            Label = label;
            MaxSpeed = maxSpeed;
            Price = price;
            Sale = sale;
        }
        public int CompareTo(Katalog obj) {
        return Price.CompareTo(obj.Price);
        }
        public override string ToString()
        {
            return $"{Id} {Label} {MaxSpeed} {Price} {Sale}";
        }
    }
}
