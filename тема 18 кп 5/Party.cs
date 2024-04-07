using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_5
{/// <summary>
/// наследуемы класс
/// </summary>
    internal class Party:Goods
    {/// <summary>
    /// конструктор по умолчанию
    /// </summary>
        public Party() { }
        /// <summary>
        /// конструктор с парамерами
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="price">price</param>
        /// <param name="count">count</param>
        /// <param name="productionDate">productionDate</param>
        /// <param name="expirationDate">expirationDate</param>
        public Party(string name, int price, int count, DateTime productionDate, DateTime expirationDate) : base(name, price)
        {
            Count = count;
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;
        }
        /// <summary>
        /// поле описывающее колличесвто
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// поле описывающее дфау производства 
        /// </summary>
        public DateTime ProductionDate { get; set; }
        /// <summary>
        /// поле описывающее срок годности
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// метод для определения срока годности товара
        /// </summary>
        /// <returns>годен ли товар</returns>
        public override string DeadlineExpirationDate()
        {
            if(ExpirationDate <= DateTime.Now)
            { return $"Просроченный товар:{Name}"; }
            else { return null; }
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns>базовый метод вывода поля класса</returns>
        public override string ToString()
        {
            
           
            return $"{base.ToString()}\nКоличество:{Count}\nДата производства:{ProductionDate.ToShortDateString()}\nСрок годности:{ExpirationDate.ToShortDateString()}\n";
        }

    }
}
