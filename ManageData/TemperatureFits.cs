using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static bool TemperatureFits(double Temperature)
        {
            if (Temperature > 60 || Temperature < -50)
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
