using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age=int.PaConsole.ReadLine();
            //Person person = new Person(16);

            //person.Print();
            //Person person1 = new Person(16,"artem");
            //person1.Print();
            //Person person2 = new Person(16, "artem", "siglov");
            //person2.Print();
            //Employee emp = new Employee(16,"atrem","siglov","Microsoft","coder");
            //emp.Print();
            //Person emp2 = new Employee(16, "atrem", "siglov", "Microsoft", "coder");
            //emp2.Print();
            //Student student = new Student(16, "atrem", "siglov", DateTime.Now, 2);
            //student.Print();

            //List<Person> persons = new List<Person>();
            //persons.Add(new Person(32, "Игорь", "Ливанов"));
            //persons.Add(new Employee(21, "Андрей", "Евсеев", "МГУ", "лаборант"));
            //persons.Add(new Student(19, "Кристина", "Любушкина", DateTime.Now, 5));
            //foreach (var p in persons)
            //    p.Print();

            List<Person> personas = new List<Person>();
            bool d = true;
            while(d)
            {
                string status = Console.ReadLine();
                switch(status)
                {
                    case "e": case "E":
                        {
                            Employee employee = new Employee();
                            personas.Add(Employee.Enter());
                            break;
                        }
                    case "s": case "S":
                        {
                            Student student = new Student();
                            personas.Add(Student.Enter());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Объекта нет");
                            d = false;
                            break;
                        }
                }
            }
            foreach(var person in personas)
            {
                person.Print();
            }
            Console.ReadLine();

        }
    }
}
