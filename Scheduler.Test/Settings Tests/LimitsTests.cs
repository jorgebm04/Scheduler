using FluentAssertions;
using Xunit;

namespace Scheduler.Test
{
    public class LimitsTests
    {
        [Fact]
        public void Validate_datetime_once_type_in_limits()
        {
            //Arrange
            var startLimit = new DateTime(2010, 1, 1, 0, 0, 0);
            var endLimit = new DateTime(2030, 10, 1, 0, 0, 0);
            var dateTime = new DateTime(2022, 10, 1, 0, 0, 0);
            var currentDate = DateTime.Today;
            var type = 0;
            //Act
            var result = LimitsChecker.CheckLimits(startLimit, endLimit, dateTime, currentDate, type);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate__datetime_once_type_not_in_limits()
        {
            //Arrange
            var startLimit = new DateTime(2030, 1, 1, 0, 0, 0);
            var endLimit = new DateTime(2030, 10, 1, 0, 0, 0);
            var dateTime = new DateTime(2022, 10, 1, 0, 0, 0);
            var currentDate = DateTime.Today;
            var type = 0;
            //Act
            var result = LimitsChecker.CheckLimits(startLimit, endLimit, dateTime, currentDate, type);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_current_date_recurring_type_in_limits()
        {
            //Arrange
            var startLimit = new DateTime(2010, 1, 1, 0, 0, 0);
            var endLimit = new DateTime(2030, 10, 1, 0, 0, 0);
            var dateTime = new DateTime(2022, 10, 1, 0, 0, 0);
            var currentDate = DateTime.Today;
            var type = 1;
            //Act
            var result = LimitsChecker.CheckLimits(startLimit, endLimit, dateTime, currentDate, type);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_current_date_recurring_type_before_start_limit()
        {
            //Arrange
            var startLimit = new DateTime(2030, 1, 1, 0, 0, 0);
            var endLimit = new DateTime(2030, 10, 1, 0, 0, 0);
            var dateTime = new DateTime(2022, 10, 1, 0, 0, 0);
            var currentDate = DateTime.Today;
            var type = 1;
            //Act
            var result = LimitsChecker.CheckLimits(startLimit, endLimit, dateTime, currentDate, type);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_current_date_recurring_type_after_end_limit()
        {
            //Arrange
            var startLimit = new DateTime(2010, 1, 1, 0, 0, 0);
            var endLimit = new DateTime(2020, 10, 1, 0, 0, 0);
            var dateTime = new DateTime(2022, 10, 1, 0, 0, 0);
            var currentDate = DateTime.Today;
            var type = 1;
            //Act
            var result = LimitsChecker.CheckLimits(startLimit, endLimit, dateTime, currentDate, type);
            //Assert
            result.Should().BeFalse();
        }
    }
}
