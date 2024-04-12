using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    class PersonalComputer:ISwitchable
    {
        public string On()
        {
            return "PC is On";
        }
        public string Off()
        {
            return "PC is Off";
        }
    }
}
