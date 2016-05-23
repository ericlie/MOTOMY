using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MotoMy.Globals
{
    public class SharedProperty
    {
        public static short MinutesOfDay
        {
            get
            {
                return Convert.ToInt16(DateTime.Now.TimeOfDay.TotalMinutes);
            }
        }
    }
}