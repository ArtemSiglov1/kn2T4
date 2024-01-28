using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date;
            //date = DateTime.Parse(Console.ReadLine());
            //DateTime date1;
            //date1 = DateTime.Parse(Console.ReadLine());
            //if (date < date1)
            //{

            //    Console.WriteLine(date1.Subtract(date).TotalDays);
            //}
            //else
            //{
            //    Console.WriteLine(date.Subtract(date1).TotalDays);
            //}
            //Console.WriteLine($"До конца месяца осталось-{DateTime.DaysInMonth(date.Year, date.Month) - date.Day} дней");
            DateTime dateTime =new DateTime(2007, 03, 23);
            DateTime dateTime1 = new DateTime(2024,03,23);
            DateTime date = DateTime.Now;
           
            Console.WriteLine($"{dateTime.DayOfWeek}\n{dateTime.DayOfYear}\n{DateTime.IsLeapYear(dateTime.Year)}\n{dateTime1.ToString("dddd, d MMMM yyy")}\n{dateTime1.Subtract(date).TotalDays}");
            if (date.Month < dateTime.Month)
            {
                Console.WriteLine($"Кол-во полных лет {date.AddYears(-dateTime.Year - 1).ToString("yy")}");
            }
            else if (date.Month == dateTime.Month)
            {
                if (date.Day < dateTime.Day)
                {
                    Console.WriteLine($"Кол-во полных лет {date.AddYears(-dateTime.Year - 1).ToString("yy")} ");
                }
                else
                {
                    Console.WriteLine($"Кол-во полных лет {date.AddYears(-dateTime.Year).ToString("yy")} ");
                }
            }
            else
            {
                Console.WriteLine($"Кол-во полных лет {date.AddYears(-dateTime.Year).ToString("yy")} ");
            }

            Console.Read();
        }
    }
}
