using System;

namespace Ex03.Entidades.Exceptions
{
    class DomainException: Exception
    {
        public DomainException(string message): base(message)
        {

        }
    }
}
