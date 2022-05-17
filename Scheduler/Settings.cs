using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Settings
    {
        public DateTime currentDate { get; set; }
        public bool enable { get; set; }
        public int type { get; set; }
        public DateTime dateTime { get; set; }
        public int occurs { get; set; }
        public Double days { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public String exit { get; set; }
        public String description { get; set; }
    }
}
