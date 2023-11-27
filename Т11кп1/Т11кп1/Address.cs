using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т11кп1
{
    /// <summary>
    /// описыв адрес
    /// </summary>
    internal class Address
    {
        /// <summary>
        /// поле индекса
        /// </summary>
        public ushort index ;
       /// <summary>
       /// поле страны
       /// </summary>
        public string country;
        /// <summary>
        /// поле города
        /// </summary>
        public string city;
        /// <summary>
        /// поле улицы
        /// </summary>
        public string street ;
        /// <summary>
        /// поле дома
        /// </summary>
        public ushort house;
        /// <summary>
        /// поле номера кв
        /// </summary>
        public ushort apart;
        /// <summary>
        /// метод вывода
        /// </summary>
        /// <returns>индекс страна город дом апартаменты</returns>
        public override string ToString()
        {
            return $"{index}\t {country} \t {city}\t {street}\t {house}\t {apart}";
        }

    }
}
