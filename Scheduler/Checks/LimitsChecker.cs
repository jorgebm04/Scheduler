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
        public static bool CheckLimits(DateTime start, DateTime end, DateTime nextSchedule, DateTime currentDay, int type)
        {
            switch (type)
            {
                case 0:
                    if (DateTime.Compare(start, nextSchedule) > 0)
                    {
                        return false;
                    }
                    break;
                case 1:
                    if (DateTime.Compare(start, currentDay) > 0 ||
                        DateTime.Compare(currentDay, end) > 0)
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}
