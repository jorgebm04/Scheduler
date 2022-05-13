using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class DateCalculator
    {
        public DateTime calculateDate(String type,String scheduleDate)
        {
            DateTime dateTimeScheduleDate = DateTime.ParseExact(scheduleDate, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            if(type.Equals("Once"))
            {
                return dateTimeScheduleDate;
            } else
            {
                DateTime calculatedDate = dateTimeScheduleDate.AddDays(1);
                return calculatedDate;
            } 
        }
    }
}
