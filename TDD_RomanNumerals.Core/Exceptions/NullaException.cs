using System;
using System.Runtime.Serialization;

namespace TDD_RomanNumerals.Tests
{
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