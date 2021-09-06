using System;
using System.IO;
using Prime.Services;
using Xunit;

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
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader(value + "");
            Console.SetIn(input);

            LeapYearService.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);

            Assert.False(_leapYearService.IsLeapYear(value));
        }

        [Theory]
        [InlineData(1600)]
        [InlineData(2000)]
        public void IsLeapYear_ExpectTrue(int value)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader(value + "");
            Console.SetIn(input);

            LeapYearService.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);

            Assert.True(_leapYearService.IsLeapYear(value));
        }

        [Fact]
        public void IsLeapYear_Below1582()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1581");
            Console.SetIn(input);

            LeapYearService.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Please insert a number higher or equal to 1582!", output);
        }

        [Fact]
        public void IsLeapYear_InvalidInteger()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("AAAAAAA");
            Console.SetIn(input);

            LeapYearService.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("This only work for numbers!", output);
        }
    }
}