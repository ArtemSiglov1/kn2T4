using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    /// <summary>
    /// наследуемый класс описывающий работника
    /// </summary>
    internal class Employee:Person
    {
        /// <summary>
        /// поле описывающее компанию
        /// </summary>
        string company;
        /// <summary>
        /// поле описывающее должность
        /// </summary>
        string job;
        /// <summary>
        /// свойство для поля компании
        /// </summary>
        public string Company { get => company; set => company = value; }
        /// <summary>
        /// свойство для поля должности
        /// </summary>
        public string Job { get => job; set => job = value; }
        /// <summary>
        /// конструткор с параметрами 
        /// </summary>
        /// <param name="age">возраст</param>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="company">компания</param>
        /// <param name="job">должность</param>
        public Employee(int age,string name,string surname,string company, string job):base(age,name,surname)
        {
            this.company = company;
            this.job = job;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"{company} {job}");
        }
    }
}
