using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп4т19_1_
{
    [Serializable]
    internal class OmissionsTeacher:Omissions
    {
        /// <summary>
        /// 
        /// </summary>
        public string Department {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OmissionsTeacher() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="midlleName"></param>
        /// <param name="facult"></param>
        /// <param name="department"></param>
        public OmissionsTeacher(string surname,string name,string midlleName,string facult,string department):base(surname,name,midlleName,facult)
        {
            Department = department;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} {Department}";
        }
        /// <summary>
        /// 
        /// </summary>
        public override void CompleteUpdateOrDeleteOmissions()
        {
            if((new DateTime(DateTime.Now.Year, 05, 25)-DateTime.Now).TotalDays < 20)
            {
                Console.WriteLine($"Пропуски преподователей {ToString()} скоро будут обновлены");
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static OmissionsTeacher Init()
        {
            Console.WriteLine("Фамилия:");
            string surname = Console.ReadLine();
            Console.WriteLine("Имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Отчество:");
            string midlleName = Console.ReadLine();
            Console.WriteLine("Факультет:");
            string facult = Console.ReadLine();
            Console.WriteLine("Кафедра:");
            string departament= Console.ReadLine();
            return new OmissionsTeacher(surname, name, midlleName, facult, departament);
        }
    }
}
