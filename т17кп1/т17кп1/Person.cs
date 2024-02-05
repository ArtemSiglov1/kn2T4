using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    internal class Person
    {
        int age;
        string name;
        string surname;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public Person() { }
        public Person(int age)
        {
            this.age = age;
        }
        public Person(int age,string name):this(age)
        {
            this.name = name;
        }
        public Person(int age, string name, string surname):this(age,name)
        {
            this.surname = surname; 
        }
        public void Print()
        {
            Console.WriteLine($"{age} {name} {surname} ");
        }
    }
}
