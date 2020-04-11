using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static bool HumidityFits(int Humidity)
        {
            if (Humidity > 100 || Humidity < 0)
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
