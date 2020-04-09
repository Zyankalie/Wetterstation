using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static bool PressureFits(int pressure)
        {
            if(pressure > 1080 || pressure < 700)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
