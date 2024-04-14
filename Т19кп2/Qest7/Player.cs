using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2.Qest7
{
    class Player : IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Music is play");
        }
        void IPlayable.Pause() { Console.WriteLine("Play music on pause"); }
        void IPlayable.Stop() { Console.WriteLine("Play music is stop"); }
        public void Recod()
        {
            Console.WriteLine("Music is record");
        }
        void IRecodable.Pause(){ Console.WriteLine("Record music on pause"); }
        void IRecodable.Stop() { Console.WriteLine("Record music is stop"); }
       
    }
}
