using System;
using System.Collections.Generic;
using System.Text;

namespace DZRM.Core
{
    public interface IKnowException
    {
        string Message { get; }
        int ErrorCode { get; }
        object[] ErrorData { get; }
    }
}
