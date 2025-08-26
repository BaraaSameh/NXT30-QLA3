using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    internal class WeeklySchedule
    {
        Dictionary<string, string> schedule = new Dictionary<string, string>();
        public string this[string day]
        {
            get => schedule.ContainsKey(day) ? schedule[day].ToString() : "No tasks scheduled";
            set => schedule[day] = value;
        }
    }
}
