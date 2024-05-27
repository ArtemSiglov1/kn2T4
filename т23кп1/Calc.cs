using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т23кп1
{
    internal class Calc
    {
      public   enum Deist
        {
           плюс,минус,делить,умножить
        }
       
       public  double Calc1(int choise,double x,double y)
        {

            switch ((Deist)choise)
            {
                case Deist.плюс:

                    return x + y;
                case Deist.минус:

                    return x - y;
                case Deist.делить:

                    return x / y;
                case Deist.умножить:

                    return x * y;
                default: return 0;
            }

        }
       
       
       
       
    }
}
