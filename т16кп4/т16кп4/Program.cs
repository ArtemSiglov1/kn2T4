using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 =DateTime.Now;
            Staff[] staffs = new Staff[1];
            for(int i=0;i<staffs.Length;i++)
            {
                string surname=Console.ReadLine(), name=Console.ReadLine(), otchestvo=Console.ReadLine(), dol=Console.ReadLine();
                DateTime date=DateTime.Parse(Console.ReadLine()),date2=DateTime.Parse(Console.ReadLine());
                double oklad=double.Parse(Console.ReadLine());
                Console.Clear();
                staffs[i] = new Staff(surname,name,otchestvo,date,dol,oklad,date1,date2);
            }
            foreach(var elem in staffs)
            {
                Console.Write($"{Staff.tabNom} {elem.ToString()}");
            }
            Console.ReadLine();
        }
    }
}
