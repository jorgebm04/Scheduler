using FluentAssertions;
using System.Globalization;
using Xunit;

namespace Scheduler.Test.Calculate_Tests
{
    public class DateCalculatorTests
    {
        [Fact]
        public void Validate_calculated_date_once_type_correct()
        {
            //Arrange
            var settings = new Settings();
            settings.currentDate = DateTime.Today;
            settings.dateTime = new DateTime(2022, 5, 20, 14, 30,0);
            settings.type = 0;
            //Act
            DateCalculator.CalculateDate(settings.currentDate, settings.dateTime, settings);
            //Assert
            settings.exit.Should().Be(settings.dateTime.ToString("dd'/'MM'/'yyyy HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_recurring_type_correct()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = DateTime.Today,
                dateTime = DateTime.ParseExact("20/05/2022 14:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                endDate = DateTime.ParseExact("20/05/2023", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                type = 1,
                occurs = 0,
                days = 5
            };
            //Act
            DateCalculator.CalculateDate(settings.currentDate, settings.dateTime, settings);
            //Assert
            settings.exit.Should().Be(settings.currentDate.AddDays(5).ToString("dd'/'MM'/'yyyy HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_recurring_type_over_end_limit()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = DateTime.Today,
                dateTime = DateTime.ParseExact("20/05/2021 14:00", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                endDate = DateTime.ParseExact("25/05/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                type = 1,
                occurs = 0,
                days = 10
            };
            //Act
            DateCalculator.CalculateDate(settings.currentDate, settings.dateTime, settings);
            //Assert
            settings.exit.Should().Be("Ocurrence over limits");
        }
    }
}
