using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т13кп1
{
    internal class Tovar
    {
        string name;
        int price, kvo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = (value > 10 || value < 1) ? 0 : value; }
        }
        public int Kvo
        {
            get { return kvo; }
            set { kvo = (value > 10 || value < 0) ? 0 : value; }
        }
        public Tovar() { }
        public Tovar(string name, int price, int kvo)
        {
            this.Name = name;
            this.Price = price;
            this.Kvo = kvo;
        }
        public override string ToString()
        {
            return $"Name-{name}\t Price-{price}\t Kvo-{kvo}";
        }
    }
}
