using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerson
{
    internal class Person:IComparable<Person>
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name-{Name} Age-{Age}";
        }

        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}
