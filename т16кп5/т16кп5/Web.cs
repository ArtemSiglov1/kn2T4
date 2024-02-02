using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп5
{
    internal class Web
    {
        
        string Address { get; set; }
        string Ip {  get; set; } 
            string WebClient{get;set;}
        DateTime DateVisit { get; set; }
            DateTime TimeVisit {  get; set; }
        public Web() { }
        public Web(string address, string ip, string webClient, DateTime dateVisit, DateTime timeVisit)
        {
            this.Address = address;
            this.Ip = ip;
            this.WebClient = webClient;
            this.DateVisit = dateVisit;
            this.TimeVisit = timeVisit;
        }
        public DayOfWeek Day()
        {
            return DateVisit.DayOfWeek;
        }
        public void Vkl(DateTime time1,DateTime time2) 
        {
         if(time1>DateVisit&&DateVisit<time2)
            {
                Console.WriteLine($"Адресс-{Address} IP-{Ip} Браузер-{WebClient} Дата визита-{DateVisit.ToLongDateString()} Время визита-{TimeVisit.ToLongTimeString()}");
            }
        }


    }
}
