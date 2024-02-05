using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    internal class Employee:Person
    {
        string company;
        string job;

        public string Company { get => company; set => company = value; }
        public string Job { get => job; set => job = value; }
        public Employee(int age,string name,string surname,string company, string job):base(age,name,surname)
        {
            this.company = company;
            this.job = job;
        }

        new public void Print()
        {
            base.Print();
            Console.WriteLine($"{company} {job}");
        }
    }
}
