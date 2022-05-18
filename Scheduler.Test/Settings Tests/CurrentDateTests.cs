using FluentAssertions;
using Xunit;

namespace Scheduler.Test
{
    public class CurrentDateTests
    {
        [Fact]
        public void Validate_current_date_after_1_second_is_current_date()
        {
            //Arrange
            var today = DateTime.Today;
            Thread.Sleep(1000);
            //Act
            var result = CurrentDayChecker.CheckCurrentDate(today);
            //Assert
            result.Should().BeTrue();
        }
        
        [Fact]
        public void Validate_incorrect_post_current_date()
        {
            //Arrange
            var date = DateTime.Today.AddDays(1);
            //Act
            var result = CurrentDayChecker.CheckCurrentDate(date);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_incorrect_pre_current_date()
        {
            //Arrange
            var date = new DateTime(2022, 1, 1, 0, 0, 0);
            //Act
            var result = CurrentDayChecker.CheckCurrentDate(date);
            //Assert
            result.Should().BeFalse();
        }
    }
}