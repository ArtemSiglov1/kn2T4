using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп4т19_1_
{
    [Serializable]
    internal class OmissionsStudent:Omissions
    {
        /// <summary>
        /// год поступления
        /// </summary>
        public int YearOfP {  get; set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public OmissionsStudent() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="midlleName">отчество</param>
        /// <param name="facult">факультет</param>
        /// <param name="yearOfP">год поступления</param>
        public OmissionsStudent(string surname,string name,string midlleName,string facult,int yearOfP):base(surname,name,midlleName,facult)
        {
            YearOfP = yearOfP;
        }
/// <summary>
/// метод вывода информации о объекте
/// </summary>
/// <returns>свойства базового и наследуемого класса</returns>
        public override string ToString()
        {
            return $"{base.ToString()} {YearOfP}";
        }
        /// <summary>
        /// 
        /// </summary>
        public override void CompleteUpdateOrDeleteOmissions()
        {
            if ((new DateTime(DateTime.Now.Year, 05, 25) - DateTime.Now).TotalDays < 80&&DateTime.Now.Year-YearOfP==3)
            {
                Console.WriteLine($"Пропуски студентов {ToString()} скоро будут анулированы");
            }
            
        }
        /// <summary>
        /// метод для ввода информации о объекте
        /// </summary>
        /// <returns></returns>
        public static OmissionsStudent Init()
        {
            Console.WriteLine("Фамилия:");
            string surname = Console.ReadLine();
            Console.WriteLine("Имя:");
            string name= Console.ReadLine();
            Console.WriteLine("Отчество:");
            string midlleName= Console.ReadLine();
            Console.WriteLine("Факультет:");
            string facult= Console.ReadLine();
            Console.WriteLine("Год поступления:");
            int yearOfP = int.Parse(Console.ReadLine());
            return new OmissionsStudent(surname,name,midlleName,facult,yearOfP);
        }
    }
}
