using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т11кп2
{
    /// <summary>
    /// Класс описывающий журнал
    /// </summary>
    internal class Journal
    {
        /// <summary>
        /// поле описывающее название 
        /// </summary>
        public string name;
        /// <summary>
        /// поля описывающие номер журнала и дату выпуска 
        /// </summary>
        public int nom,date;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Journal() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="nom">номер</param>
        /// <param name="date">дата</param>
        public Journal(string name, int nom, int date)
        {
            this.name = name;
            this.nom = nom;
            this.date = date;
        }
        /// <summary>
        /// метод для вывода информации о журнале
        /// </summary>
        /// <returns>название, номер, дата</returns>
        public override string ToString() 
        {
            return $"название-{name} номер-{nom} дата выпуска-{date}";
        }
    }
}
