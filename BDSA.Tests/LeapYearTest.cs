using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class LeapYearTest
    {
        private readonly LeapYearService _leapYearService;

        public LeapYearTest()
        {
            _leapYearService = new LeapYearService();
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void IsLeapYear_ExpectFalse(int value)
        {
            Assert.False(_leapYearService.IsLeapYear(value));
        }

        [Theory]
        [InlineData(1600)]
        [InlineData(2000)]
        public void IsLeapYear_ExpectTrue(int value)
        {
            Assert.True(_leapYearService.IsLeapYear(value));
        }
    }
}