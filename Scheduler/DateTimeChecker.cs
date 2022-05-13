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
        public DateTime checkDateTime (String dateTime)
        {          
            DateTime dt = DateTime.ParseExact(dateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            if (DateTime.Compare(dt, DateTime.Today) < 0)
            {
                throw new System.Exception();
            }
            return dt;   
        }
    }
}
