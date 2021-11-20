using System;

namespace Shared.CustomExceptions
{
    public class BookingException : Exception
    {
        public BookingException(string message) : base(message)
        {

        }
    }
}
