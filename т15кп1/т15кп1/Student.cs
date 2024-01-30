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
        /// <summary>
        /// поля описывающие ФИО и пол учинека
        /// </summary>
        string surname, name, otchestvo, pol;
        /// <summary>
        /// поле описывающее дату рождения
        /// </summary>
        DateTime date;
        /// <summary>
        /// поля описывающие счетчик
        /// </summary>
        public static int countm, countd;
        /// <summary>
        /// свойства для поля фамилии
        /// </summary>
        public string Surname
        {
            get
            {
                string x = Surname == "" ? "Фамилии нет" : surname;
                return x;
            }
            set { surname = value; }
        }
        /// <summary>
        /// свойство для поля имени
        /// </summary>
        public string Name
        {
            get
            {
                string x = Name == "" ? "Имени нет" : name;
                return x;
            }
            set { name = value; }
        }
        /// <summary>
        /// свойство для поля отчество
        /// </summary>
        public string Otchestvo
        {
            get
            {
                string x = Otchestvo == "" ? "Имени нет" : otchestvo;
                return x;
            }
            set { otchestvo = value; }
        }
        /// <summary>
        /// свойство для поля пола
        /// </summary>
        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }
        /// <summary>
        /// свойство для поля даты рождения
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>

        public Student() { }
        /// <summary>
        /// статичиский конструктор для инициализации счетчиков
        /// </summary>
        static Student()
        {
            countm = 0;
            countd = 0;
        }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="otchestvo">отчество</param>
        /// <param name="pol">пол</param>
        /// <param name="date">дата рождения</param>
        public Student(string surname, string name, string otchestvo,string pol, DateTime date)
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
        /// <summary>
        /// метод для вывода информации о студентах
        /// </summary>
        /// <returns>ФИО,пол,дата рождения</returns>
        public override string ToString()
        {
            return $"Surname-{surname}\nName-{name}\nOtchestvo-{otchestvo}\nPol-{pol}\nDate-{date}\n";
        }
    }
}
