using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Press press=new Press();
            press.Output();
            Magazine magazine=new Magazine(100,"df",10,2);
        }
    }
}
