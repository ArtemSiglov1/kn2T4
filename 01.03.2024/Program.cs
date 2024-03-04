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
                        case "q":flag = false;break;
                        default: Console.WriteLine("Данные введены не верно"); break;
                    }
                }
                foreach (var elem in person)
                {
                    Console.WriteLine(elem.ToString());
                }
                Console.WriteLine("Введите минимальный возраст:");
                int minAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите максимальный возраст:");
                int maxAge=int.Parse(Console.ReadLine());
                foreach (var elem in person)
                {
                    if (elem.Age() > minAge && elem.Age() <maxAge)
                    {
                        Console.WriteLine("\nЛюди попадающие в заданый возраст\n" + elem.ToString());
                    }
                }
            }
            catch { Console.WriteLine("Not correct data");Main(); }
            Console.ReadKey();
        }
    }
}
