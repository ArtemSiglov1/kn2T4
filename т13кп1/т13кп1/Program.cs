using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т13кп1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Иванов", 3);
            Student student2 = new Student("", -7);
            string f = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            Student student1 = new Student(f, k);

            Console.WriteLine($"{student.ToString()}\n{student2.ToString()}\n{student1.ToString()}");
            Avto avto = new Avto("bmw", "red", 10);
            Avto avto1 = new Avto("audi", "green", 45);
            Console.WriteLine($"{avto.ToString()}\n{avto1.ToString()}");
            Computer computer = new Computer();
            computer.Model = Console.ReadLine();
            computer.Ram = int.Parse(Console.ReadLine());
            computer.Hdd = int.Parse(Console.ReadLine());
            Computer computer1 = new Computer();
            computer1.Model = Console.ReadLine();
            computer1.Ram = int.Parse(Console.ReadLine());
            computer1.Hdd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{computer.ToString()}\n{computer1.ToString()}");
            Tovar tovar = new Tovar();
            tovar.Name = Console.ReadLine();
            tovar.Price = int.Parse(Console.ReadLine());
            tovar.Kvo = int.Parse(Console.ReadLine());

            Tovar tovar1 = new Tovar();
            tovar1.Name = Console.ReadLine();
            tovar1.Price = int.Parse(Console.ReadLine());
            tovar1.Kvo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{tovar.ToString()}\n{tovar1.ToString()}");
            Console.ReadKey();
        }
    }
}
