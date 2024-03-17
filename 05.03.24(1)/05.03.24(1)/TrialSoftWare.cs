using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24_1_
{
    /// <summary>
    /// условно-бесплатное ПО
    /// </summary>
    internal class TrialSoftWare:SoftWare
    {
        /// <summary>
        /// конец бесплатного пользования
        /// </summary>
        public DateTime FreeUsagePeriod {  get; set; }
        /// <summary>
        /// дата установки
        /// </summary>
        public DateTime InstallationDate { get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public TrialSoftWare() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="manufacturer">производитель</param>
        /// <param name="name">название</param>
        /// <param name="freeUsagePeriod">конец бесплатного периода</param>
        /// <param name="installationDate">дата установки</param>
        public TrialSoftWare(string manufacturer,string name,DateTime freeUsagePeriod, DateTime installationDate) : base(manufacturer, name)
        {
            FreeUsagePeriod = freeUsagePeriod;
            InstallationDate = installationDate;
        }
        /// <summary>
        /// метод вывода информации об объекте
        /// </summary>
        /// <returns>базовый метод вывода+свойства класса</returns>
        public override string ToString()
        {
            return $"{base.ToString()}Срок пользования до-{FreeUsagePeriod.ToLongDateString()}\nДата установки-{InstallationDate.ToLongDateString()}\n";
        }
        /// <summary>
        /// метод для определения соответствие возможности использования (на момент текущей даты).
        /// </summary>
        /// <returns>состояние подписки на использование ПО</returns>
        public override string IsUsableOnDate()
        {
            if (DateTime.Now > FreeUsagePeriod)
            {
                return $"Free Usage period {Name} end";
            }
            else { return $"Free Usage period {Name} not end"; }
        }
        
    }
}
