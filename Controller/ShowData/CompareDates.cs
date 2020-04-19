using System;
namespace Wetterstation
{
    partial class main
    {
        static bool CompareDates(string FirstDate, string SecondDate)
        {
            string[] FirstDateAsArray = FirstDate.Split('.');
            string[] SecondDateAsArray = SecondDate.Split('.');
            if (Convert.ToInt32(FirstDateAsArray[2]) < Convert.ToInt32(SecondDateAsArray[2]))
            {
                return true;
            }
            else if (Convert.ToInt32(FirstDateAsArray[2]) > Convert.ToInt32(SecondDateAsArray[2]))
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(FirstDateAsArray[1]) < Convert.ToInt32(SecondDateAsArray[1]))
                {
                    return true;
                }
                else if (Convert.ToInt32(FirstDateAsArray[1]) > Convert.ToInt32(SecondDateAsArray[1]))
                {
                    return false;
                }
                else
                {
                    if (Convert.ToInt32(FirstDateAsArray[0]) < Convert.ToInt32(SecondDateAsArray[0]))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}