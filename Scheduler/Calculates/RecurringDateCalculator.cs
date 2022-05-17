using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class RecurringDateCalculator 
    {
        public DateTime CalculateRecurringDate(DateTime currentDate, int freq, double days)
        {
            DateTime calculatedDate;
            //Calculates the time
            switch (freq)
            {
                case 0:
                    calculatedDate = currentDate.AddDays(days);
                    break;
                default:
                    calculatedDate = currentDate;
                    break;
            }
            return calculatedDate;
        }
    }
}
