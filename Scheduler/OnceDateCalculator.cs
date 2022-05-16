using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class OnceDateCalculator 
    {
        public DateTime calculateDate(string current, string scheduleDate)
        {
            DateTime dateTimeScheduleDate = DateTime.ParseExact(scheduleDate, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            return dateTimeScheduleDate;
        }
    }
}
