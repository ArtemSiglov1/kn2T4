using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп3
{
    internal class Time
    { 
        /// <summary>
      /// поле описывающее колличество часов 
      /// </summary>
        public int hour;
        /// <summary>
        /// поле описывающее кол во минут 
        /// </summary>
        public int minute;
        /// <summary>
        /// конструктор по умолочанию
        /// </summary>
        public Time() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="hour">часы</param>
        /// <param name="minute">минуты</param>
        public Time(int hour, int minute)
        {

            this.hour = hour;

            this.minute = minute;
        }
        /// <summary>
        /// функция формирования строки с информацией об объекте
        /// </summary>
        /// <returns>кол-во часов и минут</returns>
        public override string ToString()
        {
            return $"hour={hour}\t minute={minute}";
        }
        /// <summary>
        ///   функция обработки значений полей
        /// </summary>
        /// <returns>общее количество минут</returns>
        public int Minute()
        {
            return hour * 60 + minute;
        }
        /// <summary>
        /// поле описывающее количество секунд
        /// </summary>
        public int second;
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="hour">часы</param>
        /// <param name="minute">минуты</param>
        /// <param name="second">секунды</param>
        public Time(int hour, int minute, int second) : this(hour, minute)
        {
            this.second = second;
        }
        /// <summary>
        /// функция обработки значений полей
        /// </summary>
        /// <returns>общее количество секунд </returns>
        public int Second()
        {
            return hour * 3600 + minute * 60 + second;
        }
    }
}
