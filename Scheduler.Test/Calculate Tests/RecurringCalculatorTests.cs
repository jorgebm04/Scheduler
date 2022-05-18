using FluentAssertions;
using Xunit;

namespace Scheduler.Test.Calculate_Tests
{
    public class RecurringCalculatorTests
    {
        [Fact]
        public void Validate_correct_recurring_calculator_dayly()
        {
            //Arrange
            var currectDate = DateTime.Today;
            var freq = 0;
            var days = 5;
            RecurringDateCalculator recurringDateCalculator = new RecurringDateCalculator();    
            //Act
            var result = recurringDateCalculator.CalculateRecurringDate(currectDate, freq, days);
            //Assert
            result.Should().BeSameDateAs(currectDate.AddDays(5));
        }

        [Fact]
        public void Validate_incorrect_recurring_calculator_daily()
        {
            //Arrange
            var currectDate = DateTime.Today;
            var freq = 0;
            var days = 5;
            RecurringDateCalculator recurringDateCalculator = new RecurringDateCalculator();
            //Act
            var result = recurringDateCalculator.CalculateRecurringDate(currectDate, freq, days);
            //Assert
            result.Should().NotBeSameDateAs(currectDate.AddDays(3));
        }

        [Fact]
        public void Validate_incorrect_recurring_calculator_default()
        {
            //Arrange
            var currectDate = DateTime.Today;
            var freq = 1;
            var days = 5;
            RecurringDateCalculator recurringDateCalculator = new RecurringDateCalculator();
            //Act
            var result = recurringDateCalculator.CalculateRecurringDate(currectDate, freq, days);
            //Assert
            result.Should().BeSameDateAs(currectDate);
        }
    }
}
