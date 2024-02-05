using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    internal class Student:Person
    {
        DateTime dateB;
        int kurs;

        public DateTime DateB { get => dateB; set => dateB = value; }
        public int Kurs { get => kurs; set => kurs = value; }
        public Student(int age,string name,string surname,DateTime dateB,int kurs):base(age,name,surname)
        {
            this.dateB = dateB;
            this.kurs = kurs;
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"{dateB.ToLongDateString()} {kurs}");
        }
    }
}
