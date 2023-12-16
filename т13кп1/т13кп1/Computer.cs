using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т13кп1
{
    internal class Computer
    {
        string model;
        int ram, hdd;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Ram
        {
            get { return ram; }
            set { ram = (value < 2 || value > 32) ? 0 : value; }
        }
        public int Hdd
        {
            get { return hdd; }
            set { hdd = (value < 200 || value > 2000) ? 0 : value; }
        }
        public Computer() { }
        public Computer(string model, int ram, int hdd)
        {
            this.Model = model;
            this.Ram = ram;
            this.Hdd = hdd;
        }
        public override string ToString()
        {
            return $"Model-{model}\tRam-{ram}\tHdd-{hdd}";
        }
    }
}
