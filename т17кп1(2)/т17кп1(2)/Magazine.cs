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
            switch (i)
            {
                case 1: quality = "high"; break;
                case 2: quality = "midle"; break;
                case 3: quality = "low";  break;
                default:Console.WriteLine("no");break;

            }
        }
        new public double Cost()
        {
           if (quality =="high")
            {
                return base.Cost() + (base.Cost() * 0.1);
            }
           else if (quality == "midle")
            {
               return (base.Cost());
            }
           else if(quality == "low")
            {
                return(base.Cost() - (base.Cost() * 0.1));
            }
            else { return 0; }
        }
        new public void Output()
        {
            base.Output();
            Console.Write($"качество-{quality}\n");
        }
    }
}
