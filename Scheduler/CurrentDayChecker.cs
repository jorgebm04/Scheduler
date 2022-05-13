using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class CurrentDayChecker
    {
        public DateTime checkCurrentDate (String currentDate)
        {    
            DateTime dt = DateTime.ParseExact(currentDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (DateTime.Compare(dt, DateTime.Today) != 0)
            {
                throw new System.Exception();
            }
            return dt;  
        }
    }
}
