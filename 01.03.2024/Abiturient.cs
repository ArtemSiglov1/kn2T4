using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2024
{
    internal class Abiturient:Person
    {
        public string Facult {  get; set; }
        public Abiturient() { }
        public Abiturient(string name,string surname,DateTime dateB,string facult):base(name, surname, dateB)
        {
            Facult = facult;
        }

        public override int Age()
        {
           DateTime dateNow=DateTime.Now;
            if (dateNow.Month<=DateB.Month)
            {
                return dateNow.Year-DateB.Year-1;
            }
            else if(dateNow.Month==DateB.Month)
            {
                if (dateNow.Day<=DateB.Day)
                {
                    return dateNow.Year - DateB.Year - 1;
                }
                else
                {
                    return dateNow.Year - DateB.Year;
                }
                
            }
            else { return dateNow.Year - DateB.Year; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
