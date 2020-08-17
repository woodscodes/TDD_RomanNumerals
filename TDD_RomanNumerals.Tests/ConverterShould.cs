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

        [Fact]
        public void Convert3Into111()
        {
            Assert.All(_sutConverter.DomeSomeRangeyThing(3), n => Assert.Equal(1, n));
        }

        [Fact]
        public void RecogniseNumberUnits()
        {
            Assert.Equal("Double", _sutConverter.DigitDecider(11));
            Assert.Equal("Triple", _sutConverter.DigitDecider(121));
            Assert.Equal("Quadruple", _sutConverter.DigitDecider(1999));
        }

        [Fact]
        public void ConvertASingleDigitNumber()
        {
            Assert.Equal("VII", _sutConverter.Convert(7));
        }
    }
}
