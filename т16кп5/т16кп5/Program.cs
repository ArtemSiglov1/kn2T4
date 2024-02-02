using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            DateTime time1 =DateTime.Now;

           //Web[] webs=new Web[1];
           // for (int i=0;i<webs.Length;i++)
           // {
           //     string address=Console.ReadLine();
           //     string ip=Console.ReadLine();
           //     string WebCl=Console.ReadLine();
           //     DateTime date=DateTime.Parse(Console.ReadLine());
           //     DateTime date2=DateTime.Parse(Console.ReadLine());

           //     webs[i]=new Web(address,ip,WebCl,date,date2);
           // }
           // foreach (var web in webs) 
           // {
           //  Console.WriteLine($"{web.Day()} ");
           //     web.Vkl(time, time1);
           // }
           Dom[] doms = new Dom[2];
            for (int i = 0; i < doms.Length; i++) 
            {
                DateTime datevkl=DateTime.Parse(Console.ReadLine());
                DateTime timevkl = DateTime.Parse(Console.ReadLine());
                string temprez=Console.ReadLine();
                int tempvozd=int.Parse(Console.ReadLine());
                doms[i] = new Dom(datevkl,timevkl,temprez,tempvozd);
            }
            foreach (var dom in doms)
            {
                Console.WriteLine(dom.ToString());
            }
            foreach(var dom in doms)
            {
                dom.PlanRez();
            }
            Console.ReadLine();
        }
    }
}
