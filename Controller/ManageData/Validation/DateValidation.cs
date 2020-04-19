﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterstation
{
    partial class main
    {
        static bool DateValidation(string Date)
        {
            string[] DateAsArray = Date.Split('.');
            if (DateAsArray.Length == 3)
            {
                if (Convert.ToInt32(DateAsArray[0]) > 31 || Convert.ToInt32(DateAsArray[0]) < 0)
                {
                    return false;
                }
                else if (Convert.ToInt32(DateAsArray[1]) > 12 || Convert.ToInt32(DateAsArray[1]) < 0)
                {
                    return false;
                }
                else if (Convert.ToInt32(DateAsArray[2]) < 1900)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}