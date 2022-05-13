using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class TypeChecker
    {
        public String checkScheduleType(ComboBox types)
        {
            String type;
            if (types.SelectedIndex == -1)
            {
                throw new Exception();
            } else
            {
                type = types.SelectedItem.ToString();
            }
            return type;
        }
    }
}
