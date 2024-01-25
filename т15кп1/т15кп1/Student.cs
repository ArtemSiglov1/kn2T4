using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace т15кп1
{
    internal class Student
    {
        string surname, name, otchestvo, pol;
        int date;
        public static int countm, countd;
        public string Surname
        {
            get
            {
                string x = Surname == "" ? "Фамилии нет" : surname;
                return x;
            }
            set { surname = value; }
        }
        public string Name
        {
            get
            {
                string x = Name == "" ? "Имени нет" : name;
                return x;
            }
            set { name = value; }
        }
        public string Otchestvo
        {
            get
            {
                string x = Otchestvo == "" ? "Имени нет" : otchestvo;
                return x;
            }
            set { otchestvo = value; }
        }
        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }
        public int Date
        {
            get { return date; }
            set { date = value; }
        }

        public Student() { }
        static Student()
        {
            countm = 0;
            countd = 0;
        }
        public Student(string surname, string name, string otchestvo,string pol, int date)
        {
            this.Surname = surname;
            this.Name = name;
            this.Otchestvo = otchestvo;
            this.Pol = pol;
            this.Date = date;
            if(pol=="men"||pol=="Men")
            {
                countm++;
            }
            else if(pol=="women"||pol=="Women")
            {
                countd++;
            }
            

        }
        public override string ToString()
        {
            return $"Surname-{surname}\nName-{name}\nOtchestvo-{otchestvo}\nPol-{pol}\nDate-{date}\n";
        }
    }
}
