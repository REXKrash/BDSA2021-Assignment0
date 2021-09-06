using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class LeapYearTest
    {
        [Fact]
        public void LeapYear_IsLeapYear() 
        {
            var leapYearService = new LeapYearService();
            
            Assert.False(leapYearService.IsLeapYear(1700));
            Assert.False(leapYearService.IsLeapYear(1800));
            Assert.False(leapYearService.IsLeapYear(1900));
            Assert.True(leapYearService.IsLeapYear(1600));
            Assert.True(leapYearService.IsLeapYear(2000));
        }
    }
}