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
        public Student() { }
        public Student(int age,string name,string surname,DateTime dateB,int kurs):base(age,name,surname)
        {
            this.dateB = dateB;
            this.kurs = kurs;
        }
        //new public void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"{dateB.ToLongDateString()} {kurs}");
        //}
        public override void Print()
        {
            Console.WriteLine($"{Age} {Name} {Surname} {dateB} {kurs}");
        }
        public static Student Enter()
        {
            Console.Clear();
            int age = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            DateTime date = DateTime.Parse(Console.ReadLine());
            int kurs = int.Parse(Console.ReadLine());
            return new Student(age, name, surname, date, kurs);
        }
    }
}
