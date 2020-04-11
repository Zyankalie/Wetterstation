using System;

namespace Wetterstation
{
    partial class main
    {
        static double NthRoot(double Value, int root)
        {
            return Math.Pow(Value, 1.0 / root);
        }
    }
}
