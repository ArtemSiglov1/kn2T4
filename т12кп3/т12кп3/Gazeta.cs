using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп3
{
    internal class Gazeta
    {
        string name;
        int tir, polosa;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Tir
        {
            get { return tir; }
            set { tir = value; }
        }
        public int Polosa
        {
            get { return polosa; }
            set { polosa = value; }
        }
        public Gazeta() { }
        public Gazeta(string name, int tir, int polosa)
        {
            this.name = name;
            this.tir = tir;
            this.polosa = polosa;
           
        }
        public void Init()
        {
            Console.WriteLine("Введите название газеты");
            name = Console.ReadLine();
            Console.WriteLine("Введите тираж газеты");
            tir = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество полос");
            polosa = int.Parse(Console.ReadLine());
        }
        public void ChangeName()
        {
            Console.WriteLine("Введите новое название газеты");
            string NewName = Console.ReadLine();
            this.name = NewName;
        }
        public void ChangeNumber()
        {
            Console.WriteLine("Введите новое количество строк");
            int NewPol = int.Parse(Console.ReadLine());
            this.polosa = NewPol;
        }
        public override string ToString()
        {
            return $"Название-{name}\tТираж-{tir}\tКол-во полос-{polosa}";
        }
       
    }
}
