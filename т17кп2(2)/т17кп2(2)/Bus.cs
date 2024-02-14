using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2_2_
{
    /// <summary>
    /// класс описывающий автобус
    /// </summary>
    internal class Bus
    {
        /// <summary>
        /// поле описывающий марку
        /// </summary>
        string marka;
        /// <summary>
        /// поле описывающее количество мест
        /// </summary>
        int kvoMest;
        /// <summary>
        /// поле описывающее цену
        /// </summary>
        int price;
        /// <summary>
        /// свойство для поля марка
        /// </summary>
        public string Marka { get => marka; set => marka = value; }
        /// <summary>
        /// свойство для поля количества мест 
        /// </summary>
        public int KvoMest { get => kvoMest; set => kvoMest = value; }
        /// <summary>
        /// свойство для поля цена
        /// </summary>
        public int Price { get => price; set => price = value; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
      public Bus() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="marka">марка</param>
        /// <param name="kvoMest">кол-во мест</param>
        /// <param name="price">цена</param>
        public Bus( string marka, int kvoMest, int price)
        {
            Marka = marka;
            KvoMest = kvoMest;
            Price = price;
           
        }
        /// <summary>
        /// метод для вывода информации об объекте 
        /// </summary>
        /// <returns>значение полей марка, кол-во мест, цена </returns>
        public virtual string Output()
        {
            return $"Марка-{marka}\nКол-во мест-{kvoMest}\nЦена за место-{price}\n";
        }
        /// <summary>
        /// метод для рассчета стоимости за все места
        /// </summary>
        /// <returns>цена * кол-во мест</returns>
        public virtual int AllPrice()
        {
            return price*KvoMest;
        }
        /// <summary>
        /// Метод для ввода информации об объекте
        /// </summary>
        /// <returns>Конструктор с параметрами</returns>
        public static Bus Enter()
        {

            Console.WriteLine("Введите марку:");
            string marka = Console.ReadLine();
            Console.WriteLine("Введите количество мест:");
            int kvoMest = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за место:");
            int price = int.Parse(Console.ReadLine());

            return new Bus(marka, kvoMest, price);
        }
    }
}
