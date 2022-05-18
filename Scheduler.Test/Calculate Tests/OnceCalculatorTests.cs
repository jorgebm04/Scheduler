using FluentAssertions;
using Xunit;

namespace Scheduler.Test.Calculate_Tests
{
    public class OnceCalculatorTests
    {
        [Fact]
        public void Validate_correct_once_calculator()
        {
            //Arrange
            var dateTime = new DateTime(2022, 1, 1,0,0,0);
            OnceDateCalculator dateCalculator = new OnceDateCalculator();
            //Act
            var result = dateCalculator.CalculateOnceDate(dateTime);
            //Assert
            result.Should().BeSameDateAs(dateTime);
        }
    }
}
