using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace т12кп4
{
    /// <summary>
    /// 
    /// </summary>
    internal class Staff
    {
        string name, surname;
        int p;
        double k;
        public Staff() { }
        public Staff(string name,string surname ,int p,double k) 
        {
         this.Name = name;
            this.Surname = surname;
            this.P = p;
            this.K = k;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        { get { return surname; } set { surname = value; } }
        public int P
        { get { return p; } set {  p = value; } }
        public double K
        { get { return k;} set { k = value; } }
        public void Input()
        {
            Console.WriteLine("Введите имя");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию ");
            this.surname = Console.ReadLine();
            Console.WriteLine("Видите минимальную зарплату");
            this.p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите повышающий коэффициент");
            this.k= double.Parse(Console.ReadLine());
        }

        public override string ToString() { return $"{p*(k/100)}"; }
    }
}
