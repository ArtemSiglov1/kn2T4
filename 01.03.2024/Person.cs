using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2024
{
    abstract class Person
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public DateTime DateB {  get; set; }
        public Person() { }
        public Person(string name, string surname, DateTime dateB)
        {
            Name = name;
            Surname = surname;
            DateB = dateB;
        }

        public override string ToString()
        {
            return $"Name-{Name}\nSurname-{Surname}\nДата рождения-{DateB}";
        }
        public abstract int Age();
    }
}
