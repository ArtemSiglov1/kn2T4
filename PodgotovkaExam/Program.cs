using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(Point.Init(), Point.Init(), Point.Init());
            figure.PerimeterCalc();
            Console.ReadLine();
        }
      
    }
    
}
