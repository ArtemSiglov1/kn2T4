using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Staff> staffs = new List<Staff>();
            staffs.Add(new Staff("Ливанов","Игорь",20000,20 ));
            staffs.Add(new Ingener("Андрей", "Евсеев",20000, 20,10));
            
            foreach (var  staff in staffs) 
            {
                staff.Print();
               Console.WriteLine( staff.Doxod());
            }
            Console.Read();
        }
    }
}
