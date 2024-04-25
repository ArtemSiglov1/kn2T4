using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    internal class Culcul<T, K>
    {
        public T Value1 { get; set; }
        public K Value2 { get; set; }
        public Culcul() { }
        public Culcul(T value1, K value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public void Add()
        {
            double a = Convert.ToDouble(Value1);
            double b = Convert.ToDouble(Value2);
            Console.WriteLine($"{Value1} + {Value2} = {a + b}");
        }
        public void Sub()
        {
            double a = Convert.ToDouble(Value1);
            double b = Convert.ToDouble(Value2);
            Console.WriteLine($"{Value1} - {Value2} = {a - b}");
        }
        public void Div()
        {
            double a = Convert.ToDouble(Value1);
            double b = Convert.ToDouble(Value2);
            Console.WriteLine($"{Value1} / {Value2} = {a / b:f2}");
        }
        public void Mul()
        {
            double a = Convert.ToDouble(Value1);
            double b = Convert.ToDouble(Value2);
            Console.WriteLine($"{Value1} * {Value2} = {a * b:f2}");
        }

    }
}
