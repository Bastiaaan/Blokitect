using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Framework
{
    public class ServiceOperationException : Exception
    {
        public ServiceOperationException() : base() { }

        public ServiceOperationException(string message) : base(message) { }

        public ServiceOperationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
