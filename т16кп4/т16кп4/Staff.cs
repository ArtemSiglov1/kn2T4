using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп4
{
    class Staff
    {
        /// <summary>
        /// 
        /// </summary>
        public  int tabNom;
        /// <summary>
        /// поля описывающие ФИО и должность сотрудника
        /// </summary>
        string surname, name, otchestvo,dol;
        /// <summary>
        /// поля описывающие дату рождения,дату поступления на работу ,сегодняшнюю дату 
        /// </summary>
        DateTime date,date1,date3;
        /// <summary>
        /// поле описывающее оклад 
        /// </summary>
        double oklad;
        /// <summary>
        /// поле описывающее количество полных лет 
        /// </summary>
        string d;
        /// <summary>
        /// свойство для поля фамилии
        /// </summary>
        public string Surname { get => (surname==""?"Имени нет":surname); set => surname = value; }
        /// <summary>
        /// свойтсво для поля имени
        /// </summary>
        public string Name { get => (name==""?"имени нет":name); set => name = value; }
        /// <summary>
        /// свойтсво для поля отчество
        /// </summary>
        public string Otchestvo { get => (otchestvo==""?"Отчества нет":otchestvo); set => otchestvo = value; }
        /// <summary>
        /// свойтсво для поля должности
        /// </summary>
        public string Dol { get => (dol==""?"Должность не указана":dol); set => dol = value; }
        /// <summary>
        /// свойтсво для поля даты рождения
        /// </summary>
        public DateTime Date { get => date; set => date = value; }
        /// <summary>
        /// свойтсво для поля оклада
        /// </summary>
        public double Oklad { get => oklad; set => oklad = value; }
        /// <summary>
        /// свойтсво для поля Сегодняшней даты
        /// </summary>
        public DateTime Date1 { get => date1; set => date1 = value; }
        /// <summary>
        /// свойтсво для поля даты поступления на работу
        /// </summary>
        public DateTime Date3 { get => date3; set => date3 = value; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>

        public Staff() { }
        /// <summary>
        /// конструктор с параметрами с рассчетом количества полных лет 
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="otchestvo">отчество</param>
        /// <param name="date">дата рождения</param>
        /// <param name="dol">должность </param>
        /// <param name="oklad">оклад </param>
        /// <param name="date1">сегодняшняя дата</param>
        /// <param name="date3">дата поступления на работу</param>
        public Staff(string surname, string name, string otchestvo,DateTime date, string dol, double oklad,DateTime date1,DateTime date3)
        {
            this.Surname = surname;
            this.Name = name;
            this.Otchestvo = otchestvo;
            this.Date = date;
            this.Dol = dol;
            this.Oklad = oklad;
            this.Date1 = date1;
            this.Date3 = date3;

            if (date1.Month < date.Month)
            {
                d=date1.AddYears(-date.Year - 1).ToString("yy");
            }
            else if (date1.Month == date.Month)
            {
                if (date1.Day < date.Day)
                {
                  d= date1.AddYears(-date.Year - 1).ToString("yy");
                }
                else
                {
                   d= date1.AddYears(-date.Year).ToString("yy");
                }
            }
            else
            {
                d = date1.AddYears(-date.Year).ToString("yy");
            }
            
            
        }
        
        /// <summary>
        /// Метод для вывода информации о сотруднике 
        /// </summary>
        /// <returns>Фамилия,имя,отчество,дата рождения,должность,оклад,кол-во полных лет,дата поступления на работу,отработанное время</returns>
        public override string ToString()
        {
            return $"{surname} {name} {otchestvo} {date.ToLongDateString()} {dol} {oklad} Возраст-{d} поступил-{date3}  отработанно-{date1.Subtract(date3)} \n";
        }
        

    }
}
