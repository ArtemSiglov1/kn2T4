using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2_2_
{
    internal class Bus
    {
        string marka;
        int kvoMest;
        int price;

        public string Marka { get => marka; set => marka = value; }
        public int KvoMest { get => kvoMest; set => kvoMest = value; }
        public int Price { get => price; set => price = value; }
      public Bus() { }
        public Bus( string marka, int kvoMest, int price)
        {
            Marka = marka;
            KvoMest = kvoMest;
            Price = price;
           
        }
        public virtual string Output()
        {
            return $"{marka}\n{kvoMest}\n{price}\n";
        }
        public virtual int AllPrice()
        {
            return price*KvoMest;
        }
    }
}
