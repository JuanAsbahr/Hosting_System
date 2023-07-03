

namespace Hosting_System.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
