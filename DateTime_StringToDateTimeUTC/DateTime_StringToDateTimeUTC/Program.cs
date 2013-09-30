
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DateTime_StringToDateTimeUTC
{
    class Program
    {
        static void Main(string[] args)
        {
            string dt = "30/9/2013 10:43 AM";
            DateTime dtime = new DateTime();
            dtime = DateTime.Parse(dt).ToUniversalTime();


        }
    }
}
