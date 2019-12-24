using System;

namespace Ex02.Entities.Exceptions
{
    class DomainException: ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }
    }
}
