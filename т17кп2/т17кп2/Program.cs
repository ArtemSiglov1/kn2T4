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
            //staffs.Add(new Staff("Ливанов","Игорь",20000,20 ));
            //staffs.Add(new Ingener("Андрей", "Евсеев",20000, 20,20));
            bool flag = true;
            while (flag) 
            {
                Console.WriteLine("Status:");
                string status=Console.ReadLine();
                switch(status) 
                {
                    case "s": case "S": { Staff staff = new Staff();staffs.Add(Staff.Enter()); }break;
                    case "i": case "I": { Ingener ingener=new Ingener();staffs.Add(Ingener.Enter());}break;
                    default:  Console.Clear(); flag=false; break;
                }
            }
            foreach (var  staff in staffs) 
            {
                staff.Print();
               Console.WriteLine( $"Doxod-{staff.Doxod()}");
            }
            Console.Read();
        }
    }
}
