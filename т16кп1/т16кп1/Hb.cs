using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп1
{  
/// <summary>
/// Класс описывающий дату рождения 
/// </summary>
    internal class Hb
    {
        /// <summary>
        /// поля описывающие дату рождения
        /// </summary>
        int age, month, day;
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Hb(){}
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="age">возраст</param>
        /// <param name="month">месяц рождения</param>
        /// <param name="day">день рождения</param>
        public Hb(int age, int month, int day)
        {
            this.Age = age;
            this.Month = month;
            this.Day = day;
        }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        ///  <param name="age">возраст</param>
        /// <param name="month">месяц рождения</param>
        /// <param name="day">день рождения</param>
        /// <param name="date">сегодняшняя дата</param>
        public Hb(int age, int month, int day, DateTime date)
        {
            this.Age = age;
            this.Month = month;
            this.Day = day;
            if (date.Month < month)
            {
                Console.WriteLine($"Ты родился в {date.AddYears(-age - 1).ToString("yyy")} году");
            }
            else if (date.Month == month)
            {
                if (date.Day < day)
                {
                    Console.WriteLine($"Ты родился в {date.AddYears(-age - 1).ToString("yyy")} году");
                }
                else
                {
                    Console.WriteLine($"Ты родлися в {date.AddYears(-age).ToString("yyy")} году");
                }
            }
            else
            {
                Console.WriteLine($"Ты родлися в {date.AddYears(-age).ToString("yyy")} году");
            }
        }
        /// <summary>
        /// свойство для поля возраста
        /// </summary>
         public int Age{ get { return age; } set { age = value; } }
        /// <summary>
        /// свойство для поля месяца рождения
        /// </summary>
        public int Month { get { return month; } set { month = value; } }
        /// <summary>
        /// свойство для поля дня рождения 
        /// </summary>
        public int Day { get { return day; } set { day = value; } }
        /// <summary>
        /// метод для определения в каком году родился человек 
        /// </summary>
        /// <param name="date">сегодняшняя дата</param>
        public void Prov(DateTime date)
        {
            if (date.Month < month)
            {
                Console.WriteLine($"Ты родился в {date.AddYears(-age - 1).ToString("yyy")} году");
            }
            else if (date.Month == month)
            {
                if (date.Day < day)
                {
                    Console.WriteLine($"Ты родился в {date.AddYears(-age - 1).ToString("yyy")} году");
                }
                else
                {
                    Console.WriteLine($"Ты родлися в {date.AddYears(-age).ToString("yyy")} году");
                }
            }
            else
            {
                Console.WriteLine($"Ты родлися в {date.AddYears(-age).ToString("yyy")} году");
            }
        }
    }
}
