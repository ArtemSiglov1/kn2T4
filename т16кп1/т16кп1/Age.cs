using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп1
{
    /// <summary>
    /// класс описывающий возраст человека
    /// </summary>
    internal class Vozr
    {
        /// <summary>
        /// поля описывающие дату рождения человека
        /// </summary>
        int year,month,day;
        /// <summary>
        /// свойство для поля год рождения
        /// </summary>
        public int Year { get => year; set => year = value; }
        /// <summary>
        /// свойство для поля месяц рождения
        /// </summary>
        public int Month { get => month; set => month = value; }
        /// <summary>
        /// свойство для поля день рождения 
        /// </summary>
        public int Day { get => day; set => day = value; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>

        public Vozr() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="year">год рождения</param>
        /// <param name="month">месяц рождения</param>
        /// <param name="day">день рождения </param>
        /// <param name="date">сегодняшняя дата</param>
        public Vozr(int year, int month, int day,DateTime date) 
        {
         this.Year=year;
            this.Month=month;
            this.Day=day;
            if (date.Month < month)
            {
                Console.WriteLine($"Твой возраст {date.AddYears(-year - 1).ToString("yy")} ");
            }
            else if (date.Month == month)
            {
                if (date.Day < day)
                {
                    Console.WriteLine($"Твой возраст {date.AddYears(-year - 1).ToString("yy")} ");
                }
                else
                {
                    Console.WriteLine($"Твой возраст {date.AddYears(-year).ToString("yy")} ");
                }
            }
            else
            {
                Console.WriteLine($"Твой возраст {date.AddYears(-year).ToString("yy")} ");
            }
        }
    }
    }

