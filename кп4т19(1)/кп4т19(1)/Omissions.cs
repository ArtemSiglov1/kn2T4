using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп4т19_1_
{
    [Serializable]
    abstract class Omissions:IDelOmissions
    {
      /// <summary>
      /// 
      /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MidlleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Facult {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Omissions(){}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="midlleName"></param>
        /// <param name="facult"></param>
        public Omissions(string surname, string name, string midlleName, string facult)
        {
            Surname = surname;
            Name = name;
            MidlleName = midlleName;
            Facult = facult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Surname} {Name} {MidlleName} {Facult}";
        }
        /// <summary>
        /// реализовал интерфейс, который содержит метод, подтверждающий обновление пропуска или его аннулирование.
        /// </summary>
        public abstract void CompleteUpdateOrDeleteOmissions();
       
    }
}
