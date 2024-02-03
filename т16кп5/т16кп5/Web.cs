using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп5
{
    /// <summary>
    /// Класс описывающий посещение сайта
    /// </summary>
    internal class Web
    {
        /// <summary>
        /// адресс сайта
        /// </summary>
        string Address { get; set; }
        /// <summary>
        /// ip устройства
        /// </summary>
        string Ip {  get; set; } 
        /// <summary>
        /// браузер пользователя
        /// </summary>
            string WebClient{get;set;}
        /// <summary>
        /// дата входа
        /// </summary>
        DateTime DateVisit { get; set; }
        /// <summary>
        /// время входа
        /// </summary>
            DateTime TimeVisit {  get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Web() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="address">адрес сайта</param>
        /// <param name="ip">ip пользов</param>
        /// <param name="webClient">браузер пользов</param>
        /// <param name="dateVisit">дата визита</param>
        /// <param name="timeVisit">время визита</param>
        public Web(string address, string ip, string webClient, DateTime dateVisit, DateTime timeVisit)
        {
            this.Address = address;
            this.Ip = ip;
            this.WebClient = webClient;
            this.DateVisit = dateVisit;
            this.TimeVisit = timeVisit;
        }
        /// <summary>
        /// метод для определения дня недели
        /// </summary>
        /// <returns>день недели от даты посещения сайта</returns>
        public DayOfWeek Day()
        {
            return DateVisit.DayOfWeek;
        }
        /// <summary>
        /// метод для вывода информации о посещении сайта в заданый временной промежуток 
        /// </summary>
        /// <param name="time1"></param>
        /// <param name="time2"></param>
        public void Vkl(DateTime time1,DateTime time2) 
        {
         if(time1>DateVisit&&DateVisit<time2)
            {
                Console.WriteLine($"Адресс-{Address} IP-{Ip} Браузер-{WebClient} Дата визита-{DateVisit.ToLongDateString()} Время визита-{TimeVisit.ToLongTimeString()}");
            }
        }


    }
}
