using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп5
{
    internal class Dom
    {
        DateTime DateVkl {  get; set; }
        DateTime TimeVkl { get; set; }
        string TempRez { get; set; }
        int TempVozd {  get; set; }

        public Dom() { }
        public Dom(DateTime dateVkl, DateTime timeVkl, string tempRez, int tempVozd)
        {
            DateVkl = dateVkl;
            TimeVkl = timeVkl;
            TempRez = tempRez;
            TempVozd = tempVozd;
        }
        public override string ToString()
        {
            return $"Дата включения-{DateVkl.ToLongDateString()} Время включения-{TimeVkl.ToLongTimeString()} Темп режим-{TempRez} Темп воздуха-{TempVozd} Осталось до включения-{(TimeVkl-DateTime.Now ).TotalMinutes}";
        }
        public void PlanRez()
        {
            if (DateVkl>DateTime.Now && DateVkl < DateTime.Now.AddDays(2) )
            {
               Console.WriteLine( $"Дата включения-{DateVkl.ToLongDateString()} Время включения-{TimeVkl.ToLongTimeString()} Темп режим-{TempRez} Темп воздуха-{TempVozd}");
            }
        }
    }
}
