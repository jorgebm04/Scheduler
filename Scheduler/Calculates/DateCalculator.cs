using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class DateCalculator
    {
        public static void calculateDate(DateTime currentDate, DateTime dateTime,Settings settings)
        {
            int index = settings.type;
            DateTime calculatedDay;
            //Calculates the time
            switch (index)
            {
                case 0:
                    OnceDateCalculator onceDate = new OnceDateCalculator();
                    calculatedDay = onceDate.calculateOnceDate(dateTime);
                    settings.exit = calculatedDay.ToString("dd'/'MM'/'yyyy HH:mm");
                    settings.description = "Occurs once. Schedule will be used on " + calculatedDay.ToString("dd'/'MM'/'yyyy") + " at " +
                        calculatedDay.ToString("HH:mm") + " starting on " + settings.startDate.ToString();
                    break;
                case 1:
                    RecurringDateCalculator recurringDate = new RecurringDateCalculator();
                    calculatedDay = recurringDate.CalculateRecurringDate(currentDate, settings.occurs, settings.days);
                    DateTime dateEnd = DateTime.ParseExact(settings.endDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if (DateTime.Compare(calculatedDay, dateEnd) > 0)
                    {
                        settings.exit = "Ocurrence over limits";
                    }
                    else
                    {
                        settings.exit = calculatedDay.ToString("dd'/'MM'/'yyyy");
                        settings.description = "Occurs every day. Schedule will be used on " + calculatedDay.ToString("dd'/'MM'/'yyyy") + " at " +
                            calculatedDay.ToString("HH:mm") + " starting on " + settings.startDate.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
