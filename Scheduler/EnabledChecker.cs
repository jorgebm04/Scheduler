using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    internal class EnabledChecker
    {
        public Boolean checkEnabled(CheckBox enable)
        {
            if (enable.Checked == false)
            {
                throw new Exception();
            }
            return enable.Checked;
        }
    }
}
