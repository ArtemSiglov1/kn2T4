using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп4т19_1_
{
    [Serializable]
    internal class OmissionsBuilder:Omissions
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateStartJob {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateEndJob { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OmissionsBuilder() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="midlleName"></param>
        /// <param name="facult"></param>
        /// <param name="dateStartJob"></param>
        /// <param name="dateEndJob"></param>
        public OmissionsBuilder(string surname,string name,string midlleName,string facult,DateTime dateStartJob, DateTime dateEndJob):base(surname,name,midlleName,facult)
        {
            DateStartJob = dateStartJob;
            DateEndJob = dateEndJob;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} {DateStartJob.ToLongDateString()} {DateEndJob.ToLongDateString()}";
        }
        /// <summary>
        /// 
        /// </summary>
        public override void CompleteUpdateOrDeleteOmissions()
        {
            if ((DateEndJob - DateTime.Now).TotalDays < 10)
            {
                Console.WriteLine($"Пропуски строителей {ToString()} скоро будут анулированы");
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static OmissionsBuilder Init()
        {
            Console.WriteLine("Фамилия:");
            string surname = Console.ReadLine();
            Console.WriteLine("Имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Отчество:");
            string midlleName = Console.ReadLine();
            Console.WriteLine("Факультет:");
            string facult = Console.ReadLine();
            Console.WriteLine();
            DateTime dateStartJob=DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            DateTime dateEndJob=DateTime.Parse(Console.ReadLine());
            return new OmissionsBuilder(surname, name, midlleName, facult, dateStartJob, dateEndJob);
        }
    }
}
