using Xunit;

namespace TDD_RomanNumerals.Tests
{
    public class ConverterShould
    {
        [Fact]
        public void Convert1intoI()
        {
            var sutConverter = new NumeralConverter();
            var result = sutConverter.Convert(1);

            Assert.Equal("I", result);
        }

        [Fact]
        public void Convert3intoIII()
        {
            var sutConverter = new NumeralConverter();
            var result = sutConverter.Convert(3);

            Assert.Equal("III", result);
        }
    }
}
