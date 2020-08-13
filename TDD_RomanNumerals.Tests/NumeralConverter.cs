using System;
using System.Runtime.Serialization;

namespace TDD_RomanNumerals.Tests
{
    internal class NumeralConverter
    {
        internal string Convert(int n)
        {
            if (n <= 0)
                throw new NullaException("Nulla non est numerus");

            if (n <= 3)
                return ThreeAndUnder(n);

            if (n == 1)
                return "I";

            throw new InvalidOperationException();
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
    }

    [Serializable]
    internal class NullaException : Exception
    {
        public NullaException()
        {
        }

        public NullaException(string message) : base(message)
        {
        }

        public NullaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}