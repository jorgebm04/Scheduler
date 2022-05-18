using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class TypeChecker
    {
        public static bool CheckScheduleType(int index)
        {
            if (index == -1)
            {
                return false;
            }
            return true;
        }
    }
}
