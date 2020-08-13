using System;

namespace TDD_RomanNumerals.Tests
{
    internal class NumeralConverter
    {
        internal static string Convert(int n)
        {
            if (n == 1)
                return "I";

            throw new InvalidOperationException();
        }
    }
}