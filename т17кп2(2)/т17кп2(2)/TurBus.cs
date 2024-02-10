using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2_2_
{
    internal class TurBus:Bus
    {
        int priceTrip;

        public int PriceTrip { get => priceTrip; set => priceTrip = value; }
        public TurBus() { }
        public TurBus(string marka,int kvoMest,int price,int priceTrip):base(marka,kvoMest,price) 
        {
            this.priceTrip = priceTrip;
        }
        public override string Output()
        {
            return$"{base.Output()}{priceTrip}\n";
        }
        public override int AllPrice()
        {
            return (Price+priceTrip)*KvoMest;
        }
    }
}
