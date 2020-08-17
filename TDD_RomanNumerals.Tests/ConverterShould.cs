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
        public void Convert1IntoI()
        {
            Assert.Equal("I", _sutConverter.Convert(1));
        }

        [Fact]
        public void Convert3IntoIII()
        {
            Assert.Equal("III", _sutConverter.Convert(3));
        }
        
        [Fact]
        public void Convert10IntoX()
        {
            Assert.Equal("X", _sutConverter.Convert(10));
        }

        [Fact]
        public void Convert24IntoXXIV()
        {
            Assert.Equal("XXIV", _sutConverter.Convert(24));
        }

        [Fact]
        public void Convert450IntoCDL()
        {
            Assert.Equal("CDL", _sutConverter.Convert(450));
        }

        [Fact]
        public void Convert369IntoCCCLXIX()
        {
            Assert.Equal("CCCLXIX", _sutConverter.Convert(369));
        }

        [Fact]
        public void Convert1984IntoMCMLXXXIV()
        {
            Assert.Equal("MCMLXXXIV", _sutConverter.Convert(1984));
        }


    }
}
