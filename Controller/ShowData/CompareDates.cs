//Bei AscDesc = true überprüfung FirstDate älter als SecondDate
//Bei AscDesc = false überprüfung FirstDate jünger als SecondDate
using System;
namespace Wetterstation
{
    partial class main
    {
        static bool CompareDates(string FirstDate, string SecondDate, bool AscDesc)
        {
            string[] FirstDateAsArray = FirstDate.Split('.');
            string[] SecondDateAsArray = SecondDate.Split('.');
            if (Convert.ToInt32(FirstDateAsArray[2]) < Convert.ToInt32(SecondDateAsArray[2]))
            {
                return true && AscDesc;
            }
            else if (Convert.ToInt32(FirstDateAsArray[2]) < Convert.ToInt32(SecondDateAsArray[2]))
            {
                return false && AscDesc;
            }
            else
            {
                if (Convert.ToInt32(FirstDateAsArray[1]) < Convert.ToInt32(SecondDateAsArray[1]))
                {
                    return true && AscDesc;
                }
                else if (Convert.ToInt32(FirstDateAsArray[1]) > Convert.ToInt32(SecondDateAsArray[1]))
                {
                    return false && AscDesc;
                }
                else
                {
                    if (Convert.ToInt32(FirstDateAsArray[0]) < Convert.ToInt32(SecondDateAsArray[0]))
                    {
                        return true && AscDesc;
                    }
                    else
                    {
                        return false && AscDesc;
                    }
                }
            }
        }
    }
}