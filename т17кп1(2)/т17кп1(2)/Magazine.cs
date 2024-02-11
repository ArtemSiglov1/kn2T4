using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_2_
{
    /// <summary>
    /// класс описывающий журнал
    /// </summary>
    internal class Magazine:Press
    {
        /// <summary>
        /// поле описывающее качество
        /// </summary>
        string quality;
        /// <summary>
        /// свойтсво для поля качества
        /// </summary>
        public string Quality { get => quality; set => quality = value; }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="copies">копии</param>
        /// <param name="name">название</param>
        /// <param name="price">цена</param>
        /// <param name="i">качество</param>
        public Magazine(int copies,string name,int price,int i):base(copies,name,price)
        {
            switch (i)
            {
                case 1: quality = "high"; break;
                case 2: quality = "midle"; break;
                case 3: quality = "low";  break;
                default:Console.WriteLine("no");break;

            }
        }
        /// <summary>
        /// метод для подсчета цены тиража с учетом качества
        /// </summary>
        /// <returns>цена тиража по отношению к качеству</returns>
        new public double Cost()
        {
           if (quality =="high")
            {
                return base.Cost() + (base.Cost() * 0.1);
            }
           else if (quality == "midle")
            {
               return (base.Cost());
            }
           else if(quality == "low")
            {
                return(base.Cost() - (base.Cost() * 0.1));
            }
            else { return 0; }
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        new public void Output()
        {
            base.Output();
            Console.Write($"качество-{quality}\n");
        }
    }
}
