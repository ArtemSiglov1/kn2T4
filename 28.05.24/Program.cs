using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05._24
{
    public enum Gender
    {
        Мужской=1,
        Женский
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Kvo Stud?");
            int n = int.Parse(Console.ReadLine());
            Student.AddStudent(students,n);
            Console.ReadLine();
            Console.Clear();
            Student.PrintStudent(students);
            Console.ReadLine();
            Student.PrintMan(students);
            Console.ReadLine();
            Student.PrintWoman(students);
            Console.ReadLine();
        }
    }
}
