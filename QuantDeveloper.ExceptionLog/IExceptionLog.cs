using System;
using System.Collections.Generic;
using System.Text;

namespace QuantDeveloper.ExceptionLog
{
    public interface IExceptionLog
    {
        void LogException(string errormessage);
    }
}
