using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static bool CanBeDate(string date, char newChar)
        {
            return ((char.IsDigit(newChar) && date.Length != 2 && date.Length != 5)
                         || (newChar == '.' && (date.Length == 2 || date.Length == 5))) && date.Length < 10;
        }
    }
}
