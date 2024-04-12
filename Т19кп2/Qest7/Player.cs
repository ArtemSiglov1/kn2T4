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
        void IPlayable.Pause() { }
        void IPlayable.Stop() { }
        public void Recod()
        {

        }
        void IRecodable.Pause(){}
        void IRecodable.Stop() { }
    }
}
