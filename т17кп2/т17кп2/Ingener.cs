using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2
{
    partial class Ingener:Staff
    {
        int n;

        public int N { get => n; set => n = value; }
        public Ingener() { }
        public Ingener(string surname,string name,int p,int k,int n):base(surname, name,p,k)
        {
            N = n;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(N);
        }
        public override int Doxod()
        {
           return base.Doxod()*(n/10);
        }
        
    }
}
