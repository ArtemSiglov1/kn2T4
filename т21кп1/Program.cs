using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т21кп1
{
    internal class Program
    {
        delegate void GetMessage();
        delegate int Operation(int x, int y);
        delegate double Av(int x, int y);
        delegate int Sum1(int x, int y);
        static void Main(string[] args)
        {
            //1
            //GetMessage del; 
            //if (DateTime.Now.Hour < 12)
            //{
            //    del = GoodMorning; 
            //}
            //else
            //{
            //    del = GoodEvening;
            //}
            //del.Invoke();
            //2
            //Operation del = new Operation(Add); 
            //int result = del.Invoke(4, 5);
            //Console.WriteLine(result);
            //del = Multiply; 
            //result = del(4, 5);
            //Console.WriteLine(result);
            //del = Sub;
            //result = del(4, 5);
            //Console.WriteLine(result);
            //del = Div;
            //result = del(4, 5);
            //Console.WriteLine(result);
            //3
            //Av av = new Av(Average);
            //double result = av.Invoke(2, 5);
            //Console.WriteLine(result);
            //result= av.Invoke(2, 6);
            //Console.WriteLine(result);
            //result= av.Invoke(2, 7);
            //Console.WriteLine(result);
            //4
            Sum1 sum = new Sum1(Sum);
            int res = sum.Invoke(1, 5);
            Console.WriteLine(res);
             res = sum.Invoke(1, 6);
            Console.WriteLine(res);
            res = sum.Invoke(1, 7);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static double Average(int m,int n)
        {
            double y = 0;int x = 0;
            for(;m<=n;m++)
            {
                x++;
                y += m;
            }
            return y/x;
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Sub(int x, int y)
        {
            return  x - y;
        }
        private static int Div(int x,int y)
        {
            return x / y;
        }
        private static int Sum(int m, int n)
        {
            int y = 0; 
            for (; m <= n; m++)
            {
                y += m;
            }
            return y;
        }
    }
}
