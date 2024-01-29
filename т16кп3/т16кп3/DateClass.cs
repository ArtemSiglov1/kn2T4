using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп3
{
    /// <summary>
    /// Класс описывающий дату класса
    /// </summary>
    internal class DateClass
    {
        /// <summary>
        /// поле описывающее дату
        /// </summary>
        DateTime data;
        /// <summary>
        /// конструктор без параметров 
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// конструктор с парметрами позволяющий установить сегодняшнюю дату
        /// </summary>
        /// <param name="year">год</param>
        /// <param name="month">месяц</param>
        /// <param name="day">день</param>
        public DateClass(int year,int month,int day)
        {
            this.data = new DateTime(year,month,day);
        }
        /// <summary>
        /// свойство для чтения и записи  значения поля 
        /// </summary>
         public DateTime Data
        { get { return data; } set {  data = value; } }
        /// <summary>
        /// Метод для получения вчерашней даты
        /// </summary>
        public DateTime Yesterday()
        {
           return data.AddDays(-1);
        }
        /// <summary>
        /// Метод для получение завтрашней даты
        /// </summary>
        public DateTime Tomorrow() 
        {
            return data.AddDays(1);
        }
        /// <summary>
        /// метод для определения количетсва дней до конца месяца 
        /// </summary>
        public int EndMonth()
        {
          return  DateTime.DaysInMonth(data.Year, data.Month) - data.Day;
        }
    }
}
