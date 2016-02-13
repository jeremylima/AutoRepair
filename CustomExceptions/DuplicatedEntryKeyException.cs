using System;

namespace CustomExceptions
{
    public class DuplicatedEntryKeyException : Exception
    {
        public DuplicatedEntryKeyException()
        {
        }

        public DuplicatedEntryKeyException(string message)
            : base(message)
        {
        }

        public DuplicatedEntryKeyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}