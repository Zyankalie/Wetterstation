using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static void AlterRecord(ref Record[] WeatherData, int Position, ref Record AlteredRecord)
        {
            WeatherData[Position] = AlteredRecord;
        }
    }
}
