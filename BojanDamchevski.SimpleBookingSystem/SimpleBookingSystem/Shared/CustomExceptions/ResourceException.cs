using System;

namespace Shared.CustomExceptions
{
    public class ResourceException : Exception
    {
        public ResourceException(string message) : base(message)
        {

        }
    }
}
