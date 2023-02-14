using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class Time
    {
        public static string Correct(string timeString)
        {
            if (timeString == String.Empty)
            {
                return timeString;
            }
            try
            {
                string[] timeComponents = timeString.Split(':');
                int hours = int.Parse(timeComponents[0]);
                int minutes = int.Parse(timeComponents[1]);
                int seconds = int.Parse(timeComponents[2]);
                TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);
                DateTime dateTime = DateTime.Now.Date.Add(timeSpan);
                string result = dateTime.ToString("HH:mm:ss");
                return result;

            }
            catch (Exception)
            {

                return null;
            }

        }



    }
}
