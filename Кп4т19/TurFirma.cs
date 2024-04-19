using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кп4т19
{
    class TurFirma:IComparable<TurFirma>
    {
        string name;
        int year;
        string inn;
        int salaryOfTheYear;
        public string Name { get; set; }
        public int Year { get; set; }
        public int INN { get; set; }
        public int SalaryOfTheYear { get; set; }
        public TurFirma() { }
        public TurFirma(string name,int year,string inn,int salaryOfTheYear)
        {
            this.name = name;
            this.year = year;
            this.inn = inn;
            this.salaryOfTheYear = salaryOfTheYear;
        }
        public override string ToString()
        {
            return $"{name}\t{year}\t{inn}\t{salaryOfTheYear}\n";
        }
        public int CompareTo(TurFirma tur)
        {
            return SalaryOfTheYear.CompareTo(tur.SalaryOfTheYear);
        }
        public static TurFirma Init()
        {
            string name = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            string inn=Console.ReadLine();
            int salaryOfTheYear = int.Parse(Console.ReadLine());
            return new TurFirma(name,year,inn,salaryOfTheYear);
        }
    }
}
