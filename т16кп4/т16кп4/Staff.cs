using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп4
{
    class Staff
    {
        public static int tabNom;
        /// <summary>
        /// 
        /// </summary>
        string surname, name, otchestvo,dol;
        DateTime date,date1,date3;
        double oklad;
        string d;
        public string Surname { get => (surname==""?"Имени нет":surname); set => surname = value; }
        public string Name { get => (name==""?"имени нет":name); set => name = value; }
        public string Otchestvo { get => (otchestvo==""?"Отчества нет":otchestvo); set => otchestvo = value; }
        public string Dol { get => (dol==""?"Должность не указана":dol); set => dol = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Oklad { get => oklad; set => oklad = value; }
        public DateTime Date1 { get => date1; set => date1 = value; }
        public DateTime Date3 { get => date3; set => date3 = value; }

        public Staff() { }
        public Staff(string surname, string name, string otchestvo,DateTime date, string dol, double oklad,DateTime date1,DateTime date3)
        {
            this.Surname = surname;
            this.Name = name;
            this.Otchestvo = otchestvo;
            this.Date = date;
            this.Dol = dol;
            this.Oklad = oklad;
            this.Date1 = date1;
            this.Date3 = date3;

            if (date1.Month < date.Month)
            {
                d=date1.AddYears(-date.Year - 1).ToString("yy");
            }
            else if (date1.Month == date.Month)
            {
                if (date1.Day < date.Day)
                {
                  d= date1.AddYears(-date.Year - 1).ToString("yy");
                }
                else
                {
                   d= date1.AddYears(-date.Year).ToString("yy");
                }
            }
            else
            {
                d = date1.AddYears(-date.Year).ToString("yy");
            }
            tabNom++;
        }
        static Staff()
        {
            tabNom = 0;
        }
        public override string ToString()
        {
            return $"{surname} {name} {otchestvo} {date.ToLongDateString()} {dol} {oklad} Возраст-{d} поступил-{date3}  отработанно-{(date1.Subtract(date3)).Days} \n";
        }

    }
}
