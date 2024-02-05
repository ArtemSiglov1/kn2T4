using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_2_
{
    internal class Magazine:Press
    {
        string quality;

        public string Quality { get => quality; set => quality = value; }
        public Magazine(int copies,string name,int price,int i):base(copies,name,price)
        {
            Console.WriteLine("Введите уровень качества 1-high 2-midle 3-low");
             i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: quality = "high"; break;
                case 2: quality = "midle"; break;
                case 3: quality = "low";  break;
                default:Console.WriteLine("no");break;

            }
        }
        new public void Cost()
        {
           if (quality =="high")
            {
                Console.WriteLine(base.Cost() + (base.Cost() * 0.1));
            }
           else if (quality == "midle")
            {
                Console.WriteLine(base.Cost());
            }
           else if(quality == "low")
            {
                Console.WriteLine(base.Cost() - (base.Cost() * 0.1));
            }
        }
        new public void Output()
        {
            base.Output();
            Console.WriteLine(quality);
        }
    }
}
