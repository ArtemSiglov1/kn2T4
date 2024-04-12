using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    class TVSet:ISwitchable
    {
        public string On()
        {
            return "TV is On";
        }
        public string Off()
        {
            return "Tv is Off";
        }
    }
}
