using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Core
{
    public class KnowException : IKnowException
    {
        public string Message { get; private set; }

        public int ErrorCode { get; private set; }

        public object[] ErrorData { get; private set; }

        public readonly static IKnowException UnKnowException = new KnowException { ErrorCode = 9999, Message = "未知错误" };

        //public static IKnownException FromKnownException(IKnownException exception)
        //{
        //    return new KnownException { Message = exception.Message, ErrorCode = exception.ErrorCode, ErrorData = exception.ErrorData };
        //}
    }
}
