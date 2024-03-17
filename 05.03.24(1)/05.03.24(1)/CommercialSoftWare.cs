using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24_1_
{
    /// <summary>
    /// Комерческое ПО
    /// </summary>
    internal class CommercialSoftWare:SoftWare
    {

        /// <summary>
        /// дата установки
        ///</summary>
        public DateTime InstallationDate { get; set; }
       /// <summary>
       /// цена подписки
       /// </summary>
        public int Price {  get; set; }
        /// <summary>
        /// конец подписки
        /// </summary>
        public DateTime UsagePeriod { get; set; }
       /// <summary>
       /// конструктор по умолчанию
       /// </summary>
        public CommercialSoftWare() { }
       /// <summary>
       /// конструктор с параметрами
       /// </summary>
       /// <param name="manufacturer">производитель</param>
       /// <param name="name">название</param>
       /// <param name="installationDate">дата установки</param>
       /// <param name="price">цена подписки</param>
       /// <param name="usagePeriod">конец подписки</param>
        public CommercialSoftWare(string manufacturer,string name,DateTime installationDate, int price, DateTime usagePeriod) : base(manufacturer,name)
        {
            InstallationDate = installationDate;
            Price = price;
            UsagePeriod = usagePeriod;
        }
        /// <summary>
        /// метод вывода информации об объекте
        /// </summary>
        /// <returns>базовый метод вывода+свойства класса</returns>
        public override string ToString()
        {
            return $"{base.ToString()}Дата установки-{InstallationDate.ToLongDateString()}\nЦена-{Price}\nПериод пользования до-{UsagePeriod.ToLongDateString()}\n";
        }
        /// <summary>
        /// метод для определения соответствие возможности использования (на момент текущей даты).
        /// </summary>
        /// <returns>состояние подписки на использование ПО</returns>
        public override string IsUsableOnDate()
        {
            if (DateTime.Now > UsagePeriod)
            {
                return $"Usage period {Name} end";
            }
            else { return $"Usage period {Name} not end"; }
        }
    }
}
