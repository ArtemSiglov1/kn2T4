using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп3
{
    internal class MedProc
    {
        DateTime date;
        DateTime date1;
       static int count;
        public MedProc() { }
        public MedProc(DateTime date,DateTime date1 ,int count) 
        {
         this.date = date;
            this.date1 = date1;
            
        }
        public DateTime Date { get { return date; } set { date = value; } }
        public DateTime Date1 { get { return date1; } set { date1 = value; } }
        public int Count { get { return count; }set { count = value; } }
        public TimeSpan Allproc()
        {
            return date1.Subtract(date); 
        }
    }
}
