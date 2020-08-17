using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD_RomanNumerals.Tests
{
    public class NumeralConverter
    {
        public string Convert(int n)
        {
            if (n <= 0)
                throw new NullaException("Nulla non est numerus");

            return DigitDecider(n);
        }

        private string ThreeAndUnder(int n)
        {
            switch (n)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                default:
                    return "There was a problem";
            }
        }

        public List<int> DomeSomeRangeyThing(int n)
        {
            List<int> listy = new List<int>();
            while (n > 0)
            {
                listy.Add(n / n);
                n--;
            };

            return listy;
        }

        public string DigitDecider(int n)
        {
            var list = n.ToString().Select(x => int.Parse(x.ToString())).ToList();

            switch (list.Count())
            {
                case 1:
                    return singleDigit(list);
                case 2:
                    return "Double";
                case 3:
                    return "Triple";
                case 4:
                    return "Quadruple";
                default:
                    throw new InvalidOperationException("Something went wrong");
            }
        }

        private string singleDigit(List<int> list)
        {
            var numberDictionary = new Dictionary<int, string>
            {
                {1, "I"}, {2, "II"}, {3, "III"}, {4, "IV"}, {5, "V"}, {6, "VI"}, {7, "VII"}, {8, "VIII"}, {9, "IX"}
            };

            return numberDictionary[list[0]];
        }
    }
}