using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_2_
{
    internal class Press
    {
        int copies;
        string name;
        int price;
       

        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public Press() { }
        public Press(int copies, string name, int price)
        {
            this.copies = copies;
            this.name = name;
            this.price = price;
        }
        public int Cost()
        {
            return copies*price;
        }
        public void Output()
        {
            Console.Write($"кол-во копий-{copies}\nназвание-{name}\nцена-{price}\n");
        }
    }
}
