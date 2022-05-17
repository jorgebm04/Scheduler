using System.Globalization;

namespace Scheduler
{
    public class CurrentDayChecker
    {
        public static bool CheckCurrentDate (DateTime currentDate)
        {    
            if (DateTime.Compare(currentDate, DateTime.Today) != 0)
            {
                return false;
            }
            return true;  
        }
    }
}
