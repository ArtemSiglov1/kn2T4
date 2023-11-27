using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т11кп1
{
    /// <summary>
    /// класс Person который представляет человека
    /// </summary>
     class Person
    {
       //Person tom=new Person();
       /// <summary>
       /// поле имени человека
       /// </summary>
        public string name;
        /// <summary>
        /// поле фамилии человека 
        /// </summary>
        
         public string surname;
        /// <summary>
        /// поле возраста человека 
        /// </summary>
        public int age;
        /// <summary>
        /// метод выводы инфы о человеке
        /// </summary>
        //public void OutPut()
        //{

        //    Console.WriteLine($"Name-{name}\t Surname-{surname}\t age-{age}");
        //}
        //public string ToString()
        //{
        //    return $"Name-{name}\t Surname-{surname}\t age-{age}";
        //}
        public override string ToString()
        {
            return $"Name-{name}\t Surname-{surname}\t age-{age}";
        }
    }
}
