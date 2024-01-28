using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп1
{
    internal class Vozr
    {
        int year,month,day;
        
        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }

        public Vozr() { }
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

