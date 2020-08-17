using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace TDD_RomanNumerals.Tests
{
    public class NumeralConverter
    {
        private string _romanNumerals = "";
        private readonly Dictionary<int, string> _romanNumberDictionary = new Dictionary<int, string>
        {
            { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" },
            { 100, "C" }, { 90, "XC" }, { 50, "L" }, { 40, "XL" },
            { 10, "X"}, { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" }
        };

        public string Convert(int n)
        {
            if (n <= 0)
                throw new NullaException("Nulla non est numerus");

            return buildRomanNumerals(n);           
        }

        private string buildRomanNumerals(int n)
        {
            foreach (var key in _romanNumberDictionary.Keys)
            {
                while (n >= key)
                {
                    _romanNumerals += _romanNumberDictionary[key];
                    n -= key;
                }
            }

            return _romanNumerals;
        }
    }
}