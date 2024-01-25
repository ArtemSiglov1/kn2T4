using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т15кп1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object[] students = new Student[2];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    string surname = Console.ReadLine(), name = Console.ReadLine(), otchestvo = Console.ReadLine(), pol = Console.ReadLine();
            //    int date = int.Parse(Console.ReadLine());
            //    students[i] = new Student(surname, name, otchestvo, pol, date);
            //}
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.ToString());
            //}
            //Console.WriteLine($"men-{Student.countm}\twomen-{Student.countd}");
            Sportiki[]sportik=new Sportiki[2];
            for (int i=0; i<sportik.Length; i++) 
            {
                string surname = Console.ReadLine(), name = Console.ReadLine(), otchestvo = Console.ReadLine();
                double height = double.Parse(Console.ReadLine());
                double weight = double.Parse(Console.ReadLine());
                sportik[i]=new Sportiki(surname,name,otchestvo,height,weight);
                
            }
            foreach (var sport in sportik)
            {
                Console.WriteLine(sport.ToString());
            }
            foreach(var sport in sportik)
            {
                if(sport.Weight>70)
                {
                    Console.WriteLine(sport.ToString());
                }
            }

            Console.WriteLine($"Колчество спортсменов чей вес больше 70кг={Sportiki.count}");
            Console.ReadLine(); 
        }
    }
}
