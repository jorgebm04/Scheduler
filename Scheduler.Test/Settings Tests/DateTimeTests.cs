using FluentAssertions;
using Xunit;

namespace Scheduler.Test
{
    public class DateTimeTests
    {
        [Fact]
        public void Validate_correct_datetime_after_current_date()
        {
            //Arrange
            var currentDate = DateTime.Today;
            var dateTime = new DateTime(2022, 10, 1, 0, 0, 0);
            //Act
            var result = DateTimeChecker.CheckDateTime(dateTime, currentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_correct_datetime_is_current_date()
        {
            //Arrange
            var currentDate = DateTime.Today;
            var dateTime = DateTime.Today;
            //Act
            var result = DateTimeChecker.CheckDateTime(dateTime, currentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_datetime_before_current_date()
        {
            //Arrange
            var currentDate = DateTime.Today;
            var dateTime = new DateTime(2010, 10, 1, 0, 0, 0);
            //Act
            var result = DateTimeChecker.CheckDateTime(dateTime, currentDate);
            //Assert
            result.Should().BeFalse();
        }
    }
}
