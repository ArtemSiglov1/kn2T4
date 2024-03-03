using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2024
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                List<Person> person = new List<Person>();
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Введите кого добавить:");
                    string status = Console.ReadLine();
                    switch (status.ToLower())
                    {
                        case "a": Abiturient abiturient = new Abiturient(); person.Add(Abiturient.Init()); break;
                        case "s": Student student = new Student(); person.Add(Student.Init()); break;
                        case "t": Teacher teacher = new Teacher(); person.Add(Teacher.Init()); break;
                        default: Console.Clear();flag= false; break;
                    }
                }
                foreach (var elem in person)
                {
                    Console.WriteLine(elem.ToString());
                }
                foreach (var elem in person)
                {
                    if (elem.Age() > 18 && elem.Age() < 35)
                    {
                        Console.WriteLine("Люди попадающие в заданый возраст\n" + elem.ToString());
                    }
                }
            }
            catch { Console.WriteLine("Not correct data");Main(); }
            Console.ReadKey();
        }
    }
}
