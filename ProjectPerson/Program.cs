using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>() {new Person("Oleg",18),new Person("Artyom",17),new Person("Andrey",17),new Person("Vania",15) };
            foreach(Person person in list)
            {
                Console.WriteLine(person.ToString());
            }
            list.Sort();
            Console.WriteLine("\nSort complete\n");
            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();
        }
    }
}
