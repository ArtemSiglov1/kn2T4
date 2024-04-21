using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кп4т19_1_
{
    
    internal interface IDelOmissions
    {
        /// <summary>
        ///  метод подтверждающий обновление пропуска или его аннулирование.
        /// </summary>
        void CompleteUpdateOrDeleteOmissions();
    }
}
