using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class DateTimeChecker
    {
        public static bool CheckDateTime (DateTime dateTime, DateTime currentDate)
        {          
            if (DateTime.Compare(dateTime, currentDate) < 0)
            {
                return false;
            }
            return true;
        }
    }
}
