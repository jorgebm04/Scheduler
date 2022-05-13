using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class LimitsChecker
    {
        public void checkLimits(String start, String end, String nextSchedule,String type)
        {
            DateTime dateStart = DateTime.ParseExact(start, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dateNextSchedule = DateTime.ParseExact(nextSchedule, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            if (type.Equals("Once"))
            {
                if (DateTime.Compare(dateStart, dateNextSchedule) > 0)
                {
                    throw new Exception();
                }
            } else
            {
                DateTime dateEnd = DateTime.ParseExact(end, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (DateTime.Compare(dateStart, dateNextSchedule) > 0 || 
                    DateTime.Compare(dateNextSchedule,dateEnd) > 0)
                {
                    throw new Exception();
                }
            }
                
        }
    }
}
