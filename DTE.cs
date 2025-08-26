using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    static class DTE
    {
        public static DateTime StartOfWeek(this DateTime dt) => dt.AddDays(-(int)dt.DayOfWeek);
        public static DateTime EndOfWeek(this DateTime dt) => dt.StartOfWeek().AddDays(6);
        public static int Age(this DateTime dob) => DateTime.Now.Year - dob.Year;
    }

}
