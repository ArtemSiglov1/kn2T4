using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2_2_
{
    /// <summary>
    /// класс описывающий туристический автобус
    /// </summary>
    internal class TurBus:Bus
    {
        /// <summary>
        /// поле описывающее стоймость путешествия
        /// </summary>
        int priceTrip;
        /// <summary>
        /// свойство поля стоимости путешествия
        /// </summary>
        public int PriceTrip { get => priceTrip; set => priceTrip = value; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public TurBus() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="marka">марка</param>
        /// <param name="kvoMest">кол-во мест</param>
        /// <param name="price">цена</param>
        /// <param name="priceTrip">цена путишествия</param>
        public TurBus(string marka,int kvoMest,int price,int priceTrip):base(marka,kvoMest,price) 
        {
            this.priceTrip = priceTrip;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>метод для вывода информации об объекете базового класса и цена путишествия</returns>
        public override string Output()
        {
            return$"{base.Output()}Trip price-{priceTrip}\n";
        }
        /// <summary>
        /// метод для рассчета общей стоимости с учетом цены путешествия
        /// </summary>
        /// <returns>(цена +цена путишествия) *кол-во мест </returns>
        public override int AllPrice()
        {
            return (Price+priceTrip)*KvoMest;
        }
        /// <summary>
        /// Метод для ввода информации об объекте
        /// </summary>
        /// <returns>Конструктор с параметрами</returns>
        new public static Bus Enter()
        {

            Console.WriteLine("Введите марку:");
            string marka = Console.ReadLine();
            Console.WriteLine("Введите Количество мест:");
            int kvoMest = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за место:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за путешествие");
            int priceTrip = int.Parse(Console.ReadLine());
            return new TurBus(marka, kvoMest, price,priceTrip);
        }
    }
}
