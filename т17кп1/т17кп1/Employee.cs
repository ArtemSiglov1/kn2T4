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
        public Employee() { }
        public Employee(int age,string name,string surname,string company, string job):base(age,name,surname)
        {
            this.company = company;
            this.job = job;
        }

        public override void Print()
        {
             Console.WriteLine($"{Age} {Name} {Surname} {company} {job}");
        }
        public static Employee Enter()
        {
            Console.Clear();
            int age = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            
            string company = Console.ReadLine();
            string job = Console.ReadLine();
            return new Employee(age, name, surname, company, job);
        }
    }
}
