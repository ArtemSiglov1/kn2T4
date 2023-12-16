using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т13кп1
{
    internal class Student
    {
        
            private string fam;
            private int kurs;

            public string Fam
            {


                get
                {
                    return (fam != "") ? fam : "Неизвестно";
                }
                set { fam = value.ToUpper(); }



            }
            public int Kurs
            {
                set
                {
                    if (value < 1 || value > 4)

                        Console.WriteLine("Такого курса не бывает");

                    else

                        kurs = value;

                    //kurs=(value<1||value>4)?0:value;

                }
                get { return kurs; }
            }

            public Student() { }
            public Student(string fam, int kurs)
            {
                this.Fam = fam;
                this.Kurs = kurs;
            }
            public override string ToString()
            {
                return $"Фамилия-{Fam}\tKurs-{Kurs}";
            }
        }
}
