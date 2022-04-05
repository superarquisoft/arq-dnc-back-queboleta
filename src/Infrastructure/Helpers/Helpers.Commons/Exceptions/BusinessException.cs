using System;

namespace Helpers.Commons.Exceptions
{
    public class BusinessException : Exception
    {
        public int code { get; private set; }

        public dynamic data { get; private set; }

        public BusinessException(int errorCode, string errorMessage) : base(errorMessage)
        {
            code = errorCode;
        }

        public BusinessException(int errorCode, string errorMessage, dynamic errorData) : base(errorMessage)
        {
            code = errorCode;
            data = errorData;
        }

        public BusinessException(int errorCode, string errorMessage, Exception ex) : base(errorMessage, ex)
        {
            code = errorCode;
        }
    }
}
