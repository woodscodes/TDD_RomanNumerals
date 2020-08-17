﻿using System;
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
            { 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" }, { 10, "X"},
            { 40, "XL" }, { 50, "L" }, { 90, "XC" }, { 100, "C" },
            { 400, "CD" }, { 500, "D" }, { 900, "CM" }, { 1000, "M" }
        };

        public string Convert(int n)
        {
            if (n <= 0)
                throw new NullaException("Nulla non est numerus");

            return _romanNumerals;
        }


    }
}