using FluentAssertions;
using Xunit;

namespace Scheduler.Test
{
    public class ValidationsTests
    {
        [Fact]
        public void Validate_current_date_after_1_second_is_current_date()
        {
            //Arrange
            var today = DateTime.Today;
            Thread.Sleep(1000);
            //Act
            var result = CurrentDayChecker.CheckCurrentDate(today.ToString());
            //Assert
            result.Should().BeTrue();
        }

    }
}