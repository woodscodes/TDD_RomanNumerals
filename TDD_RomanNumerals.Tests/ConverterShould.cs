using System.Collections.Generic;
using System.ComponentModel;
using Xunit;

namespace TDD_RomanNumerals.Tests
{
    public class ConverterShould
    {
        private readonly NumeralConverter _sutConverter;

        public ConverterShould()
        {
            _sutConverter = new NumeralConverter();
        }

        [Fact]
        public void Convert1intoI()
        {
            var result = _sutConverter.Convert(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Convert3intoIII()
        {
            var result = _sutConverter.Convert(3);

            Assert.Equal("III", result);
        }   
    }
}
