using Xunit;

namespace TDD_RomanNumerals.Tests
{
    public class ConverterShould
    {
        [Fact]
        public void Convert1intoI()
        {
            var result = NumeralConverter.Convert(1);

            Assert.Equal("I", result);
        }
    }
}
