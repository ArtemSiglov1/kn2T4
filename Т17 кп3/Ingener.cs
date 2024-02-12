using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    internal class Ingener:Staff
    {
        int proekt;

        public int Proekt { get => proekt; set => proekt = value; }
        public Ingener() { }
        public Ingener(string name,string surname,DateTime dateB,int p,int proekt):base(name,surname,dateB,p) 
        {
         this.proekt = proekt;
        }
        public override string Output()
        {
            return $"{base.Output()} {proekt}";
        }
        public override double Doxod(int k)
        {
            return base.Doxod(k)+4.8*proekt;
        }
    }
}
