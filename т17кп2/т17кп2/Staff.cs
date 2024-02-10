using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2
{
     class Staff
    {
        string surname, name;
        int p,k;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public int P { get => p; set => p = value; }
        public int K { get => k; set => k = value; }
        public Staff() { }
        public Staff(string surname, string name, int p, int k)
        {
            Surname = surname;
            Name = name;
            P = p;
            K = k;
        }
        virtual public void Print()
        {
            Console.Write($"{surname}\n{name}\n{p}\n{k}\n"); 
        }
        public virtual int Doxod()
        {
            return k*p;
        }
      
    }
}
