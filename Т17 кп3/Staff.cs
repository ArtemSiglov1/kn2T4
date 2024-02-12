using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    /// <summary>
    /// 
    /// </summary>
    internal class Staff
    {
        /// <summary>
        /// 
        /// </summary>
        string name,surname;
        /// <summary>
        /// 
        /// </summary>
        DateTime dateB;
        /// <summary>
        /// 
        /// </summary>
        int p;
        /// <summary>
        /// 
        /// </summary>
        

        public string Name { get => name==""?"no":name; set => name = value; }
        public string Surname { get => surname==""?"no":surname; set => surname = value; }
        public DateTime DateB { get => dateB; set => dateB = value; }
        public int P { get => p; set => p = value; }
       

        public Staff() { }
        public Staff(string name, string surname, DateTime dateB, int p)
        {
            Name = name;
            Surname = surname;
            DateB = dateB;
            P = p; 
        }
        public virtual string Output()
        {
            return $"{name} {surname} {dateB.ToShortDateString()} {p}";
        }
        public virtual double Doxod(int k)
        {
           
            return p *k;
        }

    }
}
