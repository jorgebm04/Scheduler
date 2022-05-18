using FluentAssertions;
using Xunit;

namespace Scheduler.Test
{
    public class OccursTests
    {
        [Fact]
        public void Validate_correct_index()
        {
            //Arrange
            var index = 0;
            //Act
            var result = OccursChecker.CheckOccurs(index);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_index()
        {
            //Arrange
            var index = -1;
            //Act
            var result = OccursChecker.CheckOccurs(index);
            //Assert
            result.Should().BeFalse();
        }
    }
}
