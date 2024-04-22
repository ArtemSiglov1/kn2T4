using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп1
{
    internal class Book<Ttype>
    {
        string name;
        Ttype price;
        public string Name {  get; set; }
        public Ttype Price { get; set; }
        public  void Init(string name)
        {
            Name = name;
        } 
        public void InitPrice(Ttype price)
        {
            Price=price;
        }
        public override string ToString()
        {
            return $"{Name} {Price}";
        }
        public Book() { }
    }
}
