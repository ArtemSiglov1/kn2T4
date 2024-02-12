using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    internal class Meneger:Staff
    {
        int ob;
        public int Ob { get => ob; set => ob = value; }
        public Meneger() { }
        public Meneger(string name, string surname, DateTime dateB, int p, int ob) : base(name,surname,dateB,p)
        {
            this.ob = ob;
        }
        public override string Output() 
        {
            return $"{base.Output()} {ob}";
        }
        public override double Doxod(int k)
        {
            Console.WriteLine("Norma=");
            int n = int.Parse(Console.ReadLine());
            
            if (ob > n)
            {
                return base.Doxod(k)+(n*0.01);
            }
            else
            {
                return base.Doxod(k) ;
            }
        }
    }
}
