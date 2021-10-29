using System;
using System.Collections.Generic;
using System.Text;

namespace Blokitect.Data.Framework
{
    public class ServiceOperationResult
    {
        public bool Success { get; set; }

        public Exception Exception { get; set; }

        public string ExceptionMessage { get; set; }

        public ServiceOperationResult()
        {

        }

        public ServiceOperationResult(string message)
        {
            this.ExceptionMessage = message;
        }

        public ServiceOperationResult(bool success)
        {
            this.Success = success;
        }
        public ServiceOperationResult(Exception exception, bool success)
        {
            this.ExceptionMessage = exception.Message;
            this.Success = success;
        }

        public static ServiceOperationResult Failed()
        {
            return new ServiceOperationResult(false);
        }
    }
}
