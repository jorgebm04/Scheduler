using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Scheduler
{
    public class InfoValidator
    {
        public static void CheckInfo(Settings settings)
        {
            //Checks the Current Date      
            bool current = CurrentDayChecker.CheckCurrentDate(settings.currentDate);
            if (!current)
            {
                settings.exit = "Current date not valid.";
                return;
            }
            CheckEnableButton(settings);
        }

        public static void CheckEnableButton(Settings settings)
        {
            //Checks the Enabled Button
            if (settings.enable == false)
            {
                settings.exit = "No schedule enabled";
                return;
            } else
            {
                CheckType(settings);
            }     
        }

        public static void CheckType(Settings settings)
        {
            //Checks the Type
            bool type = TypeChecker.CheckScheduleType(settings.type);
            if (!type)
            {
                settings.exit = "Select a type of schedule.";
                return;
            }
            
            if (settings.type==0)
            {
                CheckDateTime(settings);
            } else
            {
                CheckOccurs(settings);
            }
            
        }

        public static void CheckDateTime(Settings settings)
        {
            //Checks the DateTime
            bool dateTime = DateTimeChecker.CheckDateTime(settings.dateTime, settings.currentDate);
            if (!dateTime)
            {
                settings.exit = "DateTime not valid.";
                return;
            }
            CheckLimits(settings);
        }
        public static void CheckOccurs(Settings settings)
        {         
            bool occurs = OccursChecker.CheckOccurs(settings.occurs);
            if (!occurs)
            {
                settings.exit = "Select an occurrence.";
                return;
            }          
            CheckLimits(settings);
        }

        public static void CheckLimits(Settings settings)
        {
            //Checks the Limits
            bool limits = LimitsChecker.CheckLimits(settings.startDate, settings.endDate, settings.dateTime, settings.currentDate, settings.type);
            if (!limits)
            {
                settings.exit = "Date not in the limits.";
                return;
            }

            settings.exit = "";
            return;
        }   
    }
}
