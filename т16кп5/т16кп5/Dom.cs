using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп5
{
    /// <summary>
    /// класс описывающий кондиционер в умном доме 
    /// </summary>
    internal class Dom
    {
           /// <summary>
           /// дата включения
           /// </summary>
        DateTime DateVkl {  get; set; }
        /// <summary>
        /// время включения
        /// </summary>
        DateTime TimeVkl { get; set; }
        /// <summary>
        /// температурный режим
        /// </summary>
        string TempRez { get; set; }
        /// <summary>
        /// температура воздуха
        /// </summary>
        int TempVozd {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Dom() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="dateVkl">дата включения</param>
        /// <param name="timeVkl">время включения</param>
        /// <param name="tempRez">темп режим</param>
        /// <param name="tempVozd">темп воздуха</param>
        public Dom(DateTime dateVkl, DateTime timeVkl, string tempRez, int tempVozd)
        {
            DateVkl = dateVkl;
            TimeVkl = timeVkl;
            TempRez = tempRez;
            TempVozd = tempVozd;
        }
        /// <summary>
        /// метод для вывода информации о включении кондиционера
        /// </summary>
        /// <returns>Дата включения, время включения, темп режим, темп воздуха, остаток времени до включения кондеционера</returns>
        public override string ToString()
        {
            return $"Дата включения-{DateVkl.ToLongDateString()} Время включения-{TimeVkl.ToLongTimeString()} Темп режим-{TempRez} Темп воздуха-{TempVozd} Осталось до включения-{(TimeVkl-DateTime.Now ).TotalMinutes}";
        }
        /// <summary>
        /// метод для вывода информации о включении кондиционера заплонированного на завтра
        /// </summary>
        public void PlanRez()
        {
            if (DateVkl>DateTime.Now && DateVkl < DateTime.Now.AddDays(2) )
            {
               Console.WriteLine( $"Дата включения-{DateVkl.ToLongDateString()} Время включения-{TimeVkl.ToLongTimeString()} Темп режим-{TempRez} Темп воздуха-{TempVozd}");
            }
        }
    }
}
