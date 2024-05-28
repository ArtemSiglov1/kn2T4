using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._05._24
{
    class Student
    {
        public string Fio { get; set; }
        public int YearBirth { get; set; }
        public Gender Gender { get; set; }
        public Student(string fio,int yearBirth,Gender gender) 
        {
            Fio = fio;
            YearBirth = yearBirth;
            Gender = gender;
        }
        public static void AddStudent(List<Student> students, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите фио");
                string fio = Console.ReadLine();
                Console.WriteLine("Введите год рождения");
                int yearBirth = int.Parse(Console.ReadLine());

                foreach (var j in Enum.GetValues(typeof(Gender)))
                {
                    Console.WriteLine($"{(int)j} {j}");
                }
                Console.WriteLine("Выберите пол");
                int gen = int.Parse(Console.ReadLine());
                Gender gender = 0;
                switch ((Gender)gen)
                {
                    case Gender.Мужской: gender = Gender.Мужской; break;
                    case Gender.Женский: gender = Gender.Женский; break;
                }
                students.Add(new Student(fio, yearBirth, gender));
            }
        }
        public override string ToString()
        {
            return $"{Fio} {YearBirth} {Gender}";
        }
        public static void PrintStudent(List<Student> students)
        {
            foreach(var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public static void PrintMan(List<Student> students)
        {
            foreach (var student in students  )
            {
                if (student.Gender == Gender.Мужской)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
        public static void PrintWoman(List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.Gender == Gender.Женский)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}

